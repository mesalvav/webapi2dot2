using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi2dot2.Models;

namespace webapi2dot2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public ValuesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult< IEnumerable<Employee>> Get()
        {
             IEnumerable <Employee> allEmployees = _employeeRepository.GetAllEmployee();

            ActionResult<IEnumerable<Employee>> result = new ActionResult<IEnumerable<Employee>>(allEmployees);
            
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee model = _employeeRepository.GetEmployee(id);
            if (model == null)
            {
                return NotFound();
            }
            return model;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
