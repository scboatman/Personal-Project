using System.Collections.Generic;
using LoadShareWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoadShareWebApp.Controllers
{
    public interface ILoadDetailsController
    {
        IActionResult Delete(int id);
        IEnumerable<LoadDetail> Get();
        IActionResult Get(int id);
        IActionResult Post([FromBody] LoadDetail LoadDetail);
    }
}