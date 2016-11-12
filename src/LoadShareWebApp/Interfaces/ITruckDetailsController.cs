using System.Collections.Generic;
using LoadShareWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadShareWebApp.Controllers
{
    public interface ITruckDetailsController
    {
        IActionResult Delete(int id);
        IEnumerable<TruckDetail> Get();
        IActionResult Get(int id);
        IActionResult Post([FromBody] TruckDetail truckDetail);
    }
}