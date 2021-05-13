using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbCRUD.Common.Constants;
using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.DataAccess.Implementation
{
    public class MongoCRUD : IMongoCRUD<Employee>
    {
        #region Private Variables

        private readonly IMongoDatabase databaseBase;
        private readonly IMongoClient client;
        private readonly IMongoCollection<Employee> _collection;
        private readonly IEmployeeDatabaseSettings _settings;
                
        #endregion

        #region Constructor
        public MongoCRUD(IEmployeeDatabaseSettings settings)
        {
            _settings = settings;
            client = new MongoClient(_settings.ConnectionString);
            databaseBase = client.GetDatabase(_settings.DatabaseName);
            _collection = databaseBase.GetCollection<Employee>(_settings.CollectionName);
         
        }
        #endregion


        public async Task Add(Employee employee)
        {
           await _collection.InsertOneAsync(employee);
        }

        public async Task<List<Employee>> GetAll()
        {
            return _collection.FindAsync(emp=> true).Result?.ToList();
        }

        public async Task<Employee> Get(Guid id)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", id);
            return await _collection.FindAsync(filter).Result?.FirstAsync();
        }

        public async Task Update(Guid id, Employee employee)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", id);
            var update = Builders<Employee>.Update.Set("Id", id);
            await _collection.UpdateOneAsync(filter, update);
        }

        public async Task Delete(Guid id)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", id);
            await _collection.DeleteOneAsync(filter);
        }
    }
}
