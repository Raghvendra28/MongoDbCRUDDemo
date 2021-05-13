using AutoMapper;
using MongoDbCRUD.Business.Interface;
using MongoDbCRUD.Common.DomainModel;
using MongoDbCRUD.Common.RequestModel;
using MongoDbCRUD.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCRUD.Business.Implementation
{
    public class EmployeeBusiness : IEmployeeBusiness
    {

        #region Private Variables
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        #endregion

        #region Constructor

        public EmployeeBusiness(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }
        #endregion

        #region Public Method
        public async Task AddEmployee(EmployeeDto employeeDto)
        {

            var employee = mapper.Map<Employee>(employeeDto);
            employee.CreatedAt = DateTime.UtcNow;
            employee.CreatedBy = "Raghav";
            await employeeRepository.AddEmployee(employee);
        }

        public async Task DeleteEmployee(Guid id)
        {
            await employeeRepository.DeleteEmployee(id);
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            var employee = await employeeRepository.GetEmployeeById(id);
            return employee;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await employeeRepository.GetEmployees();
            return employees;
        }

        public async Task UpdateEmployee(Guid id, EmployeeDto updateEmployee)
        {
            
            var employee = await GetEmployeeById(id);
            if (employee != null)
            {
                employee.FirstName = updateEmployee.FirstName;
                employee.LastName = updateEmployee.LastName;
                employee.ModifiedAt = DateTime.UtcNow;
                employee.ModifiedBy = "Raghav";
                employee.PrimaryAddress = mapper.Map<Address>(updateEmployee.PrimaryAddress);
                await employeeRepository.UpdateEmployee(id, employee);
            }
        }

        #endregion
    }
}
