using DapperEx;
using EntityModel.AirexpFreight;
using Newtonsoft.Json;
using PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using pub = PublicClass.PublicClass;
using bridging = PublicClass.BridgingApiUrl;

namespace AirexpFreightWebApi
{
    /// <summary>
    /// 费用确认
    /// hzh 2017.9.11
    /// </summary>
    public class ExAxplineWageConfirmController : ApiController
    {
        //[HttpPost]
        //public object Post(dynamic dyn)
        //{ 
        //    var sid = (int)dyn.sid;

        //    var wageinout = (int)dyn.wageinout;

        //    using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
        //    {
        //        var list = db.Select<Ex_axplinewage>(SqlQuery<Ex_axplinewage>.Builder().Where(item => item.isdel == 1 && item.sid == sid && item.wageinout == wageinout)).ToList();

        //        var result = BridgingApiUrl.PostUrl("shanghai", "url", "api", list);
        //        return result;
        //    }
        //}

        [HttpPost]
        public object Post(dynamic wage)
        {

            


            var wageResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffUpdateAxplineWage", wage);
            
            pub.MessageInfo wageMessage = pub.ConvertStrToMessageInfo(wageResult);


            return wageMessage;

           

        }

    }
}