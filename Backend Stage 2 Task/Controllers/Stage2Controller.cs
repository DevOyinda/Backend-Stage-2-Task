using Backend_Stage_2_Task.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Stage_2_Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Stage2Controller : Controller
    {       
        [HttpPost]
        [Route("PostCalculation")]
        public IActionResult PostCalculation([FromQuery]Input input)
        {
            var res = new Response();
            if (input.operation_type == Oyin.Addition)
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    result = input.x + input.y,
                    operation_type = input.operation_type.ToString()
                };
            }

            else if (input.operation_type == Oyin.Substraction)
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    result = input.x - input.y,
                    operation_type = input.operation_type.ToString()
                };
            }

            else if (input.operation_type == Oyin.Multiplication)
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    result = input.x * input.y,
                    operation_type = input.operation_type.ToString()
                };
            }

            else
            {
                return NoContent();
            }

            return Ok(res);                    
        }
    }
}
