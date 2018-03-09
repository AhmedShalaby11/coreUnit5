using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using unit5.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace unit5.APIs
{
    [Route("api/[controller]")]
    public class LoaderController : Controller
    {

        private readonly unit5Context _context;

        public LoaderController(unit5Context context)
        {
            _context = context;
        }

        //loader indications 
        [HttpGet("/loaders/loadIndications")]
        public JsonResult LoadData()
        {
            StreamReader reader = new StreamReader(@"C:\Users\ShalabyA\source\repos\unit5\unit5\Core\Data\TextFile.txt");
            var Object = reader.ReadToEnd();
            var record = Object.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < record.Length; i++)
            {
                var d = record[i].Split(',');
                _context.ConfCsIndication.Add(new ConfCsIndication
                {
                    name= d[0],
                    Type = d[1]
                });
            }


            _context.SaveChanges();
            return Json("OK");
        }




        //loader indications 
        [HttpGet("/loaders/Interventions")]
        public JsonResult LoadData1()
        {
            StreamReader reader = new StreamReader(@"C:\Users\ShalabyA\source\repos\unit5\unit5\Core\Data\Interventions.txt");
            var Object = reader.ReadToEnd();
            var record = Object.Split(new[] { '\n', '\r',';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < record.Length; i++)
            {
                var d = record[i].Split(',');
                _context.ConfIntervention.Add(new ConfIntervention
                {
                    InterventionName = d[0],
                    Type = d[1]
                });
            }


            _context.SaveChanges();
            return Json("OK");
        }





        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
