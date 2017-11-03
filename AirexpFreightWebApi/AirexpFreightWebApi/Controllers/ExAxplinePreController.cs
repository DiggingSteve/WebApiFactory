using DapperEx;
using System;
using System.Web.Http;
using pub = PublicClass.PublicClass;
using EntityModel.AirexpFreight;
using EntityModel.Po;
using AutoMapper;
using AirexpFreightWebApi.ExcuteException;

namespace AirexpFreightWebApi.Controllers
{
    /// <summary>
    /// 预上榜
    /// hzh 2017.9.7
    /// </summary>
    public class ExAxplinePreController : ApiController
    {


        /// <summary>
        /// 预上榜
        /// </summary>
        /// <param name="dyn">PO记录</param>
        /// <returns></returns>
        [HttpPost]
        public object PoInertIntoPre(dynamic data)
        {
            Ex_Axpline po = new Ex_Axpline();
            pub.ConvertDynToInfo<Ex_Axpline>(po, data);
            var wffPre = new Ex_AxpPreline();
            Mapper.Map(po, wffPre);
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {

                var trans = db.DbTransaction;       //总单和分单主从关系 多条分单sid同一个主单id捆绑
                var result = db.Insert<Ex_AxpPreline>(wffPre, trans);  //主单
                var wffHawbPre = new Ex_AxpPrelineHawb();
                wffPre.id = result;
                Mapper.Map(wffPre, wffHawbPre);
                var resultHawb = db.Insert<Ex_AxpPrelineHawb>(wffHawbPre, trans);     //插入分单
                if (result > 0 && resultHawb > 0)
                {
                    trans.Commit();
                    return pub.ResultMessageInfo.InsertSuccess;
                }
                else
                {
                    trans.Rollback();
                    LogHelper.LogHelper.InsertErrorLog<Ex_AxpPreline>(po);
                    return pub.ResultMessageInfo.InsertError;
                }


            }
        }

        /// <summary>
        /// hpo预上榜
        /// </summary>
        /// <param name="dyn">PO记录</param>
        /// <returns></returns>
        [HttpPost]
        public object HpoInertIntoPre(dynamic data)
        {
            Ex_HpoAxpline hpo = new Ex_HpoAxpline();
            pub.ConvertDynToInfo<Ex_HpoAxpline>(hpo, data);
            var wffPre = new Ex_AxpPreline();
            Mapper.Map(hpo, wffPre);
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {

                var trans = db.DbTransaction;       //总单和分单主从关系 多条分单sid同一个主单id捆绑
                var result = db.Insert<Ex_AxpPreline>(wffPre, trans);  //主单
                var wffHawbPre = new Ex_AxpPrelineHawb();
                wffPre.id = result;
                Mapper.Map(wffPre, wffHawbPre);
                var resultHawb = db.Insert<Ex_AxpPrelineHawb>(wffHawbPre, trans);     //插入分单
                if (result > 0 && resultHawb > 0)
                {
                    trans.Commit();
                    return pub.ResultMessageInfo.InsertSuccess;
                }
                else
                {
                    trans.Rollback();
                    LogHelper.LogHelper.InsertErrorLog<Ex_AxpPreline>(hpo);
                    return pub.ResultMessageInfo.InsertError;
                }


            }
        }

    }
}
