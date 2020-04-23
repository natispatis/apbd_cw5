﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwicz5.Models
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object JsonConvert { get; private set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }
    }
}
