using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadOutLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMentalShowerIndoor.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReadOutController : ControllerBase
    {


        private static List<ReadOut> readOuts = new List<ReadOut>()
        {
            new ReadOut() {COtwo = 250, Fugt = 30, LokaleId = "1", SensorId = 1, Temp = 20, Tryk = 1},
            new ReadOut() {COtwo = 250, Fugt = 30, LokaleId = "1", SensorId = 2, Temp = 20, Tryk = 1},
            new ReadOut() {COtwo = 250, Fugt = 30, LokaleId = "2", SensorId = 1, Temp = 20, Tryk = 1},
            new ReadOut() {COtwo = 250, Fugt = 30, LokaleId = "2", SensorId = 2, Temp = 20, Tryk = 1}
        };



        ////GET: api/<ReadOutController>
        //[HttpGet]
        //public IEnumerable<ReadOut> Get()
        //{
        //    return readOuts;
        //}


        // GET api/<ReadOutController>/5
        [HttpGet("{id}")]
        public List<ReadOut> Get(string id)
        {
            return readOuts.FindAll(i => i.LokaleId == id);
        }

        // POST api/<ReadOutController>
        [HttpPost]
        public void Post([FromBody] ReadOut value)
        {
            readOuts.Add(value);
        }



        //// DELETE api/<ReadOutController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
