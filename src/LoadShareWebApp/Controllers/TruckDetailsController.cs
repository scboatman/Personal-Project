using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoadShareWebApp.Models;
using LoadShareWebApp.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadShareWebApp.Controllers
{
    [Route("api/[controller]")]
    public class TruckDetailsController : Controller
    {
        private ITruckDetailService _service;

        // GET all trucks
        [HttpGet]
        public IEnumerable<TruckDetail> Get()
        {
            return _service.GetAllTruckDetails();
        }

        // GET a truckDetail by Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetTruckDetailById(id));
        }

        //add a truckDetail or update an existing truck
        [HttpPost]
        public IActionResult Post([FromBody]TruckDetail truckDetail)
        {
            _service.SaveTruckDetail(truckDetail);
            return Ok(truckDetail);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _service.DeleteTruckDetail(id);

            return Ok();
        }

        //constructor utilizing depandency injection
        TruckDetailsController(ITruckDetailService service)
        {
            this._service = service;
        }
    }
}
