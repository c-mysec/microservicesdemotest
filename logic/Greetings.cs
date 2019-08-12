using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace microservicesDemoWebApiC.logic
{
    public class Greetings
    {
        public string Get(string value)
        {
            return "Hello " + value + ". AspNET";
        }
    }
}
