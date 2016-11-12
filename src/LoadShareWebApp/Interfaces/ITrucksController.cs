using System.Collections.Generic;
using LoadShareWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadShareWebApp.Controllers
{
    public interface ITrucksController
    {
        IActionResult Delete(int id);
        IEnumerable<Truck> Get();
        IActionResult Get(int id);
        IActionResult Post([FromBody] Truck truck);
    }
}