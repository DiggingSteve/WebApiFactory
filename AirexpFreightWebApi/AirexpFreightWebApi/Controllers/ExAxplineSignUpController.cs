using DapperEx;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Http;
using pub = PublicClass.PublicClass;
using bridging = PublicClass.BridgingApiUrl;

namespace AirexpFreightWebApi.Controllers
{
    /// <summary>
    /// 签单
    /// </summary>
    public class ExAxplineSignUpController : ApiController
    {
        

       /// <summary>
       /// 签单同步费用以及主单
       /// </summary>
       /// <param name="dyn">{axpline:{},wage:{}}</param>
       /// <returns></returns>
        [HttpPost]
        public object Post(dynamic dyn)
        {
            var axpline = dyn.axpline;
            var wage = dyn.wage;
            if (axpline == null || wage == null)
                return pub.ResultMessageInfo.NoData ;
            var axplineResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffUpdateAxpline", axpline);
            var wageResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffSignUp", wage);
            pub.MessageInfo axplineMessage = pub.ConvertStrToMessageInfo(axplineResult);
            pub.MessageInfo wageMessage = pub.ConvertStrToMessageInfo(wageResult);
  
        
            return "{主单同步结果:"+ axplineMessage.resultstatus +"{费用同步结果:"+ wageMessage.resultstatus+"}";
        } 
    }
}