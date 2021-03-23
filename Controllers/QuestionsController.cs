using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
 
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace LinkedInQuizAPI.Controllers
{
   // [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        readonly LIQuizContext context; 
        public QuestionsController(LIQuizContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.Questions;
            //return new Models.Question[]
            //{
            //    new Models.Question() {Text = "hello"},
            //    new Models.Question() {Text = "hi"}


            //};

        }

        [HttpPost]
        public void  Post([FromBody] Models.Question question)
        {

            context.Questions.Add(question);
            context.SaveChanges();
            Debug.WriteLine($"{question.Text} output at {DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss")}");
            Console.WriteLine($"{question.Text} output at {DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss")}");
            //    string json = System.Text.Json.JsonSerializer.Serialize(body);
          //  return Ok();
        }

        private IActionResult OkResult()
        {
            Debug.WriteLine("OK Result");
            return OkResult();
        }
    }
}
