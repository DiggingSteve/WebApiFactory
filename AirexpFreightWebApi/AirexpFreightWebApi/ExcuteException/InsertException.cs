using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace AirexpFreightWebApi.ExcuteException
{
    public class InsertException   :System.Exception
    {
        public InsertException(string msg)
            : base(msg)
        {
           
        }
        public InsertException(string msg,Dictionary<string,string> data)
            : base(msg)
        {
            Data = data;
        }
        /// <summary>
        /// 业务异常数据
        /// </summary>
        public Dictionary<string, string> Data { get; set; }
    }
}