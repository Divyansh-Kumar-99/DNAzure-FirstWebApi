using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IActionResult Get()
        {
            var Emplist = new List<Employee>()
            {
                new Employee() {EName="Divyansh",EId=100,EDept="Development",EPno=1234567890},
                new Employee() {EName="DKumar",EId=102,EDept="Security",EPno=1234567890},
                new Employee() {EName="Dkumar2",EId=104,EDept="Management",EPno=1234567890},
                new Employee() {EName="DKumar3",EId=106,EDept="Transport",EPno=1234567890},
                new Employee() {EName="DKumar4",EId=108,EDept="FoodSupply",EPno=1234567890}
            };
            return Ok(Emplist);
        }
    }
}
