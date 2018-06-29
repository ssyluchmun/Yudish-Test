using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace wcfcoretest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        
        // GET api/values
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            yield return proxy.GetStudentsAsync().ToString();
            //return new string[] { "value1", "value2" };


        }*/

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var x = await proxy.GetStudentsAsync();
            ServiceReference1.Student newStudent =

                new ServiceReference1.Student()

                {

                    StudentId = 0,

                    FirstName = "cores",

                    LastName = "cores",

                    RegisterNo = "cores",

                    Department = "cores"

                };



            await proxy.AddStudentsAsync(newStudent);

            var x = await proxy.GetStudentsAsync();
            return Ok(x);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        { 
            return "value";
        }

        // POST api/values
        //[HttpPost]
        //public async Task<IActionResult> Put([FromBody]string value)
        //{
        //    var x = await proxy.GetStudentsAsync();

        //    return Ok(x);
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Post(int id, [FromBody]string value)
        //{
        //    ServiceReference1.Student newStudent =

        //        new ServiceReference1.Student()

        //        {

        //            StudentId = 5,

        //            FirstName = "Mark",

        //            LastName = "Dallas",

        //            RegisterNo = "278589243579432",

        //            Department = "DEPT"

        //        };



        //    await proxy.AddStudentsAsync(newStudent);

        //    return null;
        //}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
