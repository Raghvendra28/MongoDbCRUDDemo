using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.Common.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.Business.Interface
{
    public interface IEmployeeBusiness
    {
        Task<List<Employee>> GetEmployees();

        Task<Employee> GetEmployeeById(Guid id);

        Task AddEmployee(EmployeeDto employee);

        Task UpdateEmployee(Guid id, EmployeeDto employee);

        Task DeleteEmployee(Guid id);
    }
}
