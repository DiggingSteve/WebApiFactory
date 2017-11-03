using DapperEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using pub = PublicClass.PublicClass;
using PublicClass;
using EntityModel.Basic;
using bridging = PublicClass.BridgingApiUrl;

using Newtonsoft.Json;

namespace AirexpFreightWebApi.Controllers
{
    public class AiraxpNodeController : ApiController
    {
        [HttpPost]
        public object Post(dynamic data)
        {   string nodeName=data.nodeName;
            Dictionary<string, string> nodeMap = new Dictionary<string, string>();
            string nodeStr = DataByUrl.GetTypeCode(97);
            var nodeLst = pub.ConvertStrToList<NodeView>(nodeStr);
            nodeLst = nodeLst.Where(p=>p.ready02=="0").ToList();
            //var node = nodeLst.Where(p => p.typename == nodeName).FirstOrDefault();
            //var wageResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffUpdateAxplineWage", node);

            //pub.MessageInfo wageMessage = pub.ConvertStrToMessageInfo(wageResult);


            return nodeLst;
            
        }
    }
}
