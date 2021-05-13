using MongoDbCRUD.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.DataAccess.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(Guid id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Guid Id, Employee employee);
        Task DeleteEmployee(Guid id);
    }
}
