using EnterpriseManagement2.Models;
using EnterpriseManagement2.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseManagement2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly EmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetEmployees();
        }

    }
}
