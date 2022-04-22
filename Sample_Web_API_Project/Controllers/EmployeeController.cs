using Microsoft.AspNetCore.Mvc;
using Sample_Web_API_Project.Model;
using Sample_Web_API_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Web_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _empservice;
        public EmployeeController(IEmployeeServices empservice)
        {
            _empservice = empservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IActionResult GetEmployee()
        {
            return new ObjectResult(_empservice.GetAllEmployee());
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.AddEmployee(emp));
        }

        [HttpPost]
        [Route("ModifyEmployee")]
        public IActionResult ModifyEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.ModifyEmployee(emp));
        }

        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return new ObjectResult(_empservice.DeleteEmployee(id));
        }
    }
}
