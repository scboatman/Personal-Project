using System.Collections.Generic;
using LoadShareWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadShareWebApp.Controllers
{
    public interface ILoadsController
    {
        IActionResult Delete(int id);
        IEnumerable<Load> Get();
        IActionResult Get(int id);
        IActionResult Post([FromBody] Load load);
    }
}