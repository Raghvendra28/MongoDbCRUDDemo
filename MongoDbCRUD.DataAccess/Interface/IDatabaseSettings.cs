using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbCRUD.DataAccess.Interface
{
    public interface IDatabaseSettings
    {
         string EmployeesCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}
