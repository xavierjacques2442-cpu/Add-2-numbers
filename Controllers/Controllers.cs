using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add_2_numbers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddControllers : ControllerBase
    {
         [HttpGet]
     [Route("Add_2_Numbers")]
     public string Add_2_Numbers([FromQuery] int Number1, [FromQuery] int Number2)
     {
            var sum = Number1 + Number2;
            return $"The sum of {Number1} and {Number2} is {sum}";
     } 
    }
}