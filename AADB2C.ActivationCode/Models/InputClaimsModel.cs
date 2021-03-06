﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AADB2C.ActivationCode.Models
{
    public class InputClaimsModel
    {
        public string email { get; set; }

        public string systemCode { get; set; }
        public string userCode { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static InputClaimsModel Parse(string JSON)
        {
            return JsonConvert.DeserializeObject(JSON, typeof(InputClaimsModel)) as InputClaimsModel;
        }
    }
}
