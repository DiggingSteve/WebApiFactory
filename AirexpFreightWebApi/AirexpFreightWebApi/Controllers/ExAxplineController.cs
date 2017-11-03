using DapperEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using pub = PublicClass.PublicClass;
using bridging = PublicClass.BridgingApiUrl;
using Newtonsoft.Json;
using EntityModel.AirexpFreight;

namespace AirexpFreightWebApi.Controllers
{
    /// <summary>
    /// 上榜
    /// hzh 2017.9.11
    /// </summary>
    public class ExAxplineController : ApiController
    {
        // GET api/ex_axpline
        [HttpGet]
        public IEnumerable<Ex_axpline> Get()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var sqlQuery = SqlQuery<Ex_axpline>.Builder()
                                                   .Top(10);
                return db.Select<Ex_axpline>(sqlQuery)
                         .ToList();

            }
        }

        //确认上榜
        // POST api/ex_axpline
        [HttpPost]
        public object Post(dynamic dyn)
        {
            var id = (int)dyn.id;
            var addman = (string)dyn.addman;
              Ex_axpline model;
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {    //查出预上榜记录
                var search = db.Select<Ex_AxpPreline>(SqlQuery<Ex_AxpPreline>.Builder().Where(d => d.id == id))
                               .FirstOrDefault();
                if (search == null)
                {
                    return pub.ResultMessage<DBNull>(pub.ResultMessageInfo.NoData);
                }

                model = GetAxplineModel(search, addman);
                var resultId = db.Insert<Ex_axpline>(model);  //插入主单,此时要向po POST 记录同步

                if (resultId <= 0)
                {
                    LogHelper.LogHelper.InsertFatalLog<Ex_axpline>(model);
                    return pub.ResultMessage<DBNull>(pub.ResultMessageInfo.InsertError);
                }
                model.id = resultId;
                
                
            }
            OnboardConfirm(model);
            return pub.ResultMessage<DBNull>(pub.ResultMessageInfo.InsertSuccess);
        }

        public object OnboardConfirm(Ex_axpline data)
        {


        
             
            var datamodel = bridging.PostUrl("SHANGHAI", "PoManagementWebApi_WFF", "PoWffOnBoardConfirm", data);

            pub.MessageInfo messageInfo = pub.ConvertStrToMessageInfo(datamodel); 
            
            if (messageInfo.resultstatus  != 0)
            {
                return pub.ResultMessage<DBNull>(messageInfo);
            }
            else
            {
                
                return pub.ResultMessage<DBNull>(pub.ResultMessageInfo.InsertSuccess);
            }

          


        }
        private static Ex_axpline GetAxplineModel(Ex_AxpPreline search, string userName)
        {
            var model = new Ex_axpline();
            pub.UpdateObject(model, search);    //类似automapper,将pre记录 转换成 上榜记录
            model.isdel = 1;
            model.addman = model.modifyman = userName;
            model.adddate = model.modifydate = DateTime.Now;
            model.dzstatus = 100;
            model.deldate = new DateTime(1900, 1, 1);
            return model;
        }


    }
}
