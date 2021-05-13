using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbCRUD.Common.Constants;
using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.DataAccess.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Private Variables

        public readonly IMongoCRUD<Employee> _mongoCRUD;
        public readonly string tableName;

        #endregion

        #region Constructor
        public EmployeeRepository(IMongoCRUD<Employee> mongoCRUD)
        {
            _mongoCRUD = mongoCRUD;
            tableName = DbContant.Employee_Table;
        }

        public async Task AddEmployee(Employee employee)
        {
            await _mongoCRUD.Add(employee);
        }

        public async Task DeleteEmployee(Guid id)
        {
            await _mongoCRUD.Delete(id);
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            var employee = await _mongoCRUD.Get(id);
            return employee;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employess = await _mongoCRUD.GetAll();
            return employess;
        }

        public async Task UpdateEmployee(Guid id, Employee employee)
        {
            await _mongoCRUD.Update(id, employee);
        }

        #endregion

    }
}
