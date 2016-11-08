using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoadShareWebApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadShareWebApp.Controllers
{
    [Route("api/[controller]")]
    public class LoadsController : Controller
    {
        static List<Load> _loads = new List<Load>
        {
            new Load {Id = 1, Age = "8m", Origin = "Tucson", OriginState = "AZ", Destination = "Chicago", DestinationState = "IL", TrailerType = "V", LoadSize = "Full", Length = 53, Weight = 8000, PayRate = 550m, ShipDate = "Nov 10", Company = "WalMart" }
        };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Load> Get()
        {
            return _loads;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Load load = _loads.Find(p => p.Id == id);
            if (load == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(load);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Load load)
        {
            _loads.Add(load);
            return Created("/loads/" + load.Id, load);
        }



        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
