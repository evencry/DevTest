using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HealthOnline.DevTest.CurrencyProviderApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}