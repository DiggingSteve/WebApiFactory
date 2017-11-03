using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PoModel = EntityModel.Po;
using StoreModel = EntityModel.Store;
using EntityModel.AirexpFreight;
using AutoMapper;
using System.Dynamic;
using DapperEx;
using pub = PublicClass.PublicClass;
using Newtonsoft.Json;
using bridging = PublicClass.BridgingApiUrl;


namespace AirexpFreightWebApi.Controllers
{
    public class ExStoreController : ApiController
    {   [HttpPost]
        public object PostStoreToPo(dynamic store)
        {
            StoreModel.Ex_Store storeWff = new StoreModel.Ex_Store();
            pub.ConvertDynToInfo<StoreModel.Ex_Store>(storeWff, store);
            dynamic data = new ExpandoObject();//post data           
            var poStore = new PoModel.Ex_Store();
            Mapper.Map<StoreModel.Ex_Store, PoModel.Ex_Store>(storeWff, poStore);
            data.Store = poStore;
            #region 根据store里面的gzdno = wff工作号 在pre表里找出 dom(区分po/hpo) oid(po主键)
            var preLine = new Ex_AxpPreline();
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                preLine = db.Select<Ex_AxpPreline>(SqlQuery<Ex_AxpPreline>.Builder().Where(p => p.jobno == storeWff.Gzdno)).FirstOrDefault();
                if (preLine == null) return pub.ResultMessageInfo.NoData;
                data.Dom = preLine.dom;
                data.PoId = preLine.oid;
            }
            #endregion
            var storeResult = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffStore", data);

            pub.MessageInfo storeMessage = pub.ConvertStrToMessageInfo(storeResult);


            return storeMessage;

      
        }



    }
}
