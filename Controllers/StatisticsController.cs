﻿using System;
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
            return "{\"hours\": 8000,\"co2\": [{\"country\": \"Denmark\",\"value\": 167},{\"country\": \"Finland\",\"value\": 106},{\"country\": \"Norway\",\"value\": 4},{\"country\": \"Sweden\",\"value\": 10},{\"country\": \"Germany\",\"value\": 425},{\"country\": \"the Netherlands\",\"value\": 451},{\"country\": \"Ireland\",\"value\": 456},{\"country\": \"United Kingdom\",\"value\": 389}],\"cost\": [{\"country\": \"Denmark\",\"small\": 0.091325,\"medium\": 0.07835,\"large\": 0.076975},{\"country\": \"Finland\",\"small\": 0.066525,\"medium\": 0.05305,\"large\": 0.0506},{\"country\": \"Norway\",\"small\": 0.06145,\"medium\": 0.050975,\"large\": 0.04725},{\"country\": \"Sweden\",\"small\": 0.0537,\"medium\": 0.0476,\"large\": 0.039775},{\"country\": \"Germany\",\"small\": 0.129075,\"medium\": 0.105525,\"large\": 0.0906},{\"country\": \"the Netherlands\",\"small\": 0.0796,\"medium\": 0.066733,\"large\": 0.0667},{\"country\": \"Ireland\",\"small\": 0.1079,\"medium\": 0.092925,\"large\": 0.084675},{\"country\": \"United Kingdom\",\"small\": 0.134466,\"medium\": 0.131533,\"large\": 0.128366}]}";
        }
    }
}
