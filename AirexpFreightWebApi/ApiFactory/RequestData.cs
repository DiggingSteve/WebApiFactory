using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiFactory.Attribute;

namespace ApiFactory
{
    
    public class RequestData
    {
        public dynamic Data { get; set; }

        public string Module { get; set; }

        public string Domain { get; set; }

        public string Method { get; set; }
            
    }
}