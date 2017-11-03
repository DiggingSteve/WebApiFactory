using EntityModel.Basic;
using PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bridging = PublicClass.BridgingApiUrl;
using pub = PublicClass.PublicClass;
using System.Dynamic;
using  EntityModel.AirexpFreight;


namespace AirexpFreightWebApi.Business
{
    public class AiraxpNodeBll
    {


        public static NodeView GetNodeView(string nodeName)
        {
            string nodeStr = DataByUrl.GetTypeCode(97);
            var nodeLst = pub.ConvertStrToList<NodeView>(nodeStr);
            nodeLst = nodeLst.Where(p => p.ready02 == "0").ToList();
            return nodeLst.Where(p => p.typename == nodeName).FirstOrDefault();
        }

        public static pub.MessageInfo SyncPoAiraxpNode(string nodeName, string dom, int oid)
        {
            dynamic postData = new ExpandoObject();
            postData.node = AiraxpNodeBll.GetNodeView(nodeName);
            postData.oid = oid;
            postData.dom = dom;
            var wageResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffSyncAiraxpNode", postData);
            pub.MessageInfo wageMessage = pub.ConvertStrToMessageInfo(wageResult);
            return wageMessage;

        }

        
    }
}