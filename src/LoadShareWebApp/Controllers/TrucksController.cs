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
    public class TrucksController : Controller
    {
        static List<Truck> _trucks = new List<Truck>
        {
            new Truck {Id = 1, Origin = "Chicago", OriginState = "IL", Destination = "Tuscon", DestinationState = "AZ", TrailerType = "R", ShipDate = "Dec 12", Company = "Boatman Trucking"},
        };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Truck> Get()
        {
            return _trucks;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Truck truck = _trucks.Find(p => p.Id == id);
            if (truck == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(truck);
            }
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
