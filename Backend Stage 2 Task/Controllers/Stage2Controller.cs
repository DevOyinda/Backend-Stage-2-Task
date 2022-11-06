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
        [Route("/Stage2/PostCalculation")]
        public IActionResult PostCalculation(Input input)
        {
            var res = new Response();

            List<Response> response = new List<Response>();


            if (input.operation_type == "addition")
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    operation_type = input.operation_type,
                    result = Enum.Parse<Oyin>("addition") == Oyin.addition ? input.x + input.y : 0
                    
                };
            }


            else if (input.operation_type == "subtraction")
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    operation_type = input.operation_type,
                    result = Enum.Parse<Oyin>("subtraction") == Oyin.subtraction ? input.x - input.y : 0
                    
                };
            }

            else if (input.operation_type == "multiplication")
            {
                res = new Response()
                {
                    slackUsername = "DevOyinda",
                    operation_type = input.operation_type,
                    result = Enum.Parse<Oyin>("multiplication") == Oyin.multiplication ? input.x * input.y : 0
                    
                };
            }

            else
            {
                return NoContent();
            }

            response.Add(res);

            return Ok(response.FirstOrDefault());                    
        }

        [HttpGet]
        [Route("/Test")]
        public IActionResult Recharge()
        {
            var res = new Response()
            {
                slackUsername = "DevOyinda",
                operation_type = "oyinda",
                result = 10
            };

            return Ok(res);
        }
    }
}
