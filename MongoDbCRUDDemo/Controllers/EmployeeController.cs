using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDbCRUD.Business.Interface;
using MongoDbCRUD.Common.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbCRUDDemo.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Private Variables

        private readonly IEmployeeBusiness employeeBusiness;

        #endregion

        #region Constructor
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            this.employeeBusiness = employeeBusiness;
        }
        #endregion

        [HttpGet]
        [Route("api/employees")]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            var employees =await employeeBusiness.GetEmployees();
            if(employees.Count>0)
            {
                return Ok(employees);
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("api/employees/id")]
        public async Task<IActionResult> GetEmployeeByIdAsync(Guid id)
        {
            var employee = await employeeBusiness.GetEmployeeById(id);
            if (employee!=null)
            {
                return Ok(employee);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("api/employees")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeDto employeeDto)
        {
            await employeeBusiness.AddEmployee(employeeDto);
            return Ok();
        }

        [HttpPut]
        [Route("api/employees/id")]
        public async Task<IActionResult> UpdateEmployeeAsync(Guid id, [FromBody] EmployeeDto employeeDto)
        {
            await employeeBusiness.UpdateEmployee(id, employeeDto);
            return Ok();
        }

        [HttpDelete]
        [Route("api/employees/id")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            await employeeBusiness.DeleteEmployee(id);
            return Ok();
        }
    }
}
