using System;
using DapperEx;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using bridging = PublicClass.BridgingApiUrl;
using pub = PublicClass.PublicClass;

namespace AirexpFreightWebApi.Controllers
{
    /// <summary>
    /// 提交结算
    /// hzh 2017.9.11
    /// </summary>
    public class ExAxplineSubmitSettController : ApiController
    {

        [HttpPost]
        public object Post(dynamic dyn)
        {
            var axpline = dyn.axpline;
            var wage = dyn.wage;
            if (axpline == null || wage == null)
                return pub.ResultMessageInfo.NoData;
  
            var axplineResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffUpdateAxpline", axpline);
            var wageResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffUpdateAxplineWage", wage);
            pub.MessageInfo axplineMessage = pub.ConvertStrToMessageInfo(axplineResult);
            pub.MessageInfo wageMessage = pub.ConvertStrToMessageInfo(wageResult);


            return "{主单同步结果:" + axplineMessage.resultstatus + "{费用同步结果:" + wageMessage.resultstatus + "}";
        }
         
    }
}