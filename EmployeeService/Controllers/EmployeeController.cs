using Infrastructure.Model.Application;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeRepository _employeeRepository;
        private ILogger<Employee> _logger;
        public EmployeeController(EmployeeRepository employeeRepository, ILogger<Employee> logger)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            _logger.Log(LogLevel.Information, "Api Get Called");
            return _employeeRepository.GetAll();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            _logger.Log(LogLevel.Information, "Api Get By Id Called");
            return _employeeRepository.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public bool Post([FromBody] Employee value)
        {
            _logger.Log(LogLevel.Information, "Api Post Employee Called");
            return _employeeRepository.Add(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Employee value)
        {
            _logger.Log(LogLevel.Information, "Api Put Employee Called");
            return _employeeRepository.Update(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public bool Delete([FromBody] Employee value)
        {
            _logger.Log(LogLevel.Information, "Api Delete Employee Called");
            return _employeeRepository.Delete(value);
        }
    }
}
