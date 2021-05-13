using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MongoDbCRUD.DataAccess.Implementation
{
    public class EmployeeDatabaseSettings :IEmployeeDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IEmployeeDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}

