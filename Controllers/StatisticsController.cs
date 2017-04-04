using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NodePoleApi.Controllers
{
    [Route("api/statistics")]
    public class StatisticsController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "{\"hours\": 8000,\"cost\": [{\"country\": \"Denmark\",\"small\": 0.091325,\"medium\": 0.07835,\"large\": 0.076975,\"emissions\": 167},{\"country\": \"Finland\",\"small\": 0.066525,\"medium\": 0.05305,\"large\": 0.0506,\"emissions\": 106},{\"country\": \"Norway\",\"small\": 0.06145,\"medium\": 0.050975,\"large\": 0.04725,\"emissions\": 4},{\"country\": \"Sweden\",\"small\": 0.0537,\"medium\": 0.0476,\"large\": 0.039775,\"emissions\": 10},{\"country\": \"Germany\",\"small\": 0.129075,\"medium\": 0.105525,\"large\": 0.0906,\"emissions\": 425},{\"country\": \"the Netherlands\",\"small\": 0.0796,\"medium\": 0.066733,\"large\": 0.0667,\"emissions\": 451},{\"country\": \"Ireland\",\"small\": 0.1079,\"medium\": 0.092925,\"large\": 0.084675,\"emissions\": 456},{\"country\": \"United Kingdom\",\"small\": 0.134466,\"medium\": 0.131533,\"large\": 0.128366,\"emissions\": 389}]}";
        }
    }
}
