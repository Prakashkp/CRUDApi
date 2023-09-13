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
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAll();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeRepository.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public bool Post([FromBody] Employee value)
        {
            return _employeeRepository.Add(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Employee value)
        {
            return _employeeRepository.Update(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public bool Delete([FromBody] Employee value)
        {
            return _employeeRepository.Delete(value);
        }
    }
}
