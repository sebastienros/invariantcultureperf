using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InvariantCulture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("InvariantCultureIgnoreCase/{count}")]
        public ActionResult InvariantCultureIgnoreCase(int count)
        {
            var data = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            for (var i = 0; i < count; i++)
            {
                data.TryAdd("Id_", i);
            }

            return Ok();
        }

        [HttpGet]
        [Route("OrdinalIgnoreCase/{count}")]
        public ActionResult OrdinalIgnoreCase(int count)
        {
            var data = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (var i = 0; i < count; i++)
            {
                data.TryAdd("Id_", i);
            }

            return Ok();
        }
    }
}
