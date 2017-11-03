using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DapperEx;
using pub = PublicClass.PublicClass;
using EntityModel.AirexpFreight;
using EntityModel.Po;
using Newtonsoft.Json;
using System.Linq;
using AutoMapper;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using PublicClass;
using EntityModel.Basic;



namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PoInsertIntoWffAxplinePre()
        {
            EntityMapper.Configuration.Configure();
            var wff = new Ex_AxpPreline();
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcPoManagement)))
            {
                var po = db.Select<Ex_Axpline>(SqlQuery<Ex_Axpline>.Builder().Where(p => p.id == 9)).FirstOrDefault();

                Mapper.Map(po, wff);
                Console.WriteLine(JsonConvert.SerializeObject(wff));
            }

            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var trans = db.DbTransaction;

                Console.WriteLine("插入wffPre");
                var result = db.Insert<Ex_AxpPreline>(wff, trans);

                Console.WriteLine(result);

                var wffHawbPre = new Ex_AxpPrelineHawb();
                wff.id = result;
                Mapper.Map(wff, wffHawbPre);
                db.Insert<Ex_AxpPrelineHawb>(wffHawbPre, trans);
                trans.Commit();


            }
        }

        /// <summary>
        /// 测试预上榜
        /// </summary>
        /// <param name="data"></param>
        [TestMethod]
        public void PostWffPre()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcPoManagement)))
            {
                var po = db.Select<Ex_Axpline>(SqlQuery<Ex_Axpline>.Builder().Where(p => p.id == 14)).FirstOrDefault();
                var hpo = db.Select<Ex_HpoAxpline>(SqlQuery<Ex_HpoAxpline>.Builder().Where(p => p.id == 14)).FirstOrDefault();
                

                var result = pub.PostDataByUrl("http://localhost:49776/api/ExAxplinePre/PoInertIntoPre", po);
                var resultHpo = pub.PostDataByUrl("http://localhost:49776/api/ExAxplinePre/HpoInertIntoPre", hpo);
                Console.WriteLine(result);
                Console.WriteLine(resultHpo);

            }
        }

        public void TestOnboard()
        {
            var resultPost = pub.PostDataByUrl("http://localhost:49776/api/ExAxpline/post", new Ex_AxpPreline { id = 25 });

            Console.WriteLine(resultPost);
        }



        /// <summary>
        /// 测试上榜确认之后wff post 到 po  Po接口测试Step 1
        /// </summary>
        public void TestOnboardConfirm()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var po = db.Select<Ex_axpline>(SqlQuery<Ex_axpline>.Builder().Where(p => p.id == 285995)).FirstOrDefault();



                var result = pub.PostDataByUrl("http://localhost:49776/api/ExAxpline/OnBoardConfirm", po);

                Console.WriteLine(result);


            }
        }

        /// <summary>
        /// 测试签单     step 2
        /// </summary>
        public void TestSignUp()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                dynamic data = new ExpandoObject();
                var wage = db.Select<Ex_axplinewage>(SqlQuery<Ex_axplinewage>.Builder().Where(p => p.id == 4508796)).FirstOrDefault();

                var axpline = db.Select<Ex_axpline>(SqlQuery<Ex_axpline>.Builder().Where(p => p.id == 287082)).FirstOrDefault();

                data.axpline = axpline;
                data.wage = wage;

                //var result = pub.PostDataByUrl("http://localhost:49776/api/ExAxplineSignUp", data);


                Console.WriteLine(JsonConvert.SerializeObject(axpline));
                Console.WriteLine(JsonConvert.SerializeObject(wage));


            }
        }
        /// <summary>
        /// 费用确认    step 3
        /// </summary>
        public void TestWageConfirm()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var wage = db.Select<Ex_axplinewage>(SqlQuery<Ex_axplinewage>.Builder().Where(p => p.id == 4508796)).FirstOrDefault();
                wage.quote = 1.1M;
                
                var result = pub.PostDataByUrl("http://localhost:49776/api/ExAxplineWageConfirm", wage);
                Console.WriteLine(result);
            }

        }

        public void TestWageInsert()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                dynamic data = new ExpandoObject();
                var wage = db.Select<Ex_axplinewage>(SqlQuery<Ex_axplinewage>.Builder().Where(p => p.sid == 287085));
                
                data.pono = "PO1710240014";
                data.wageinfo = wage;
                var result = pub.PutDataByUrl("http://localhost:49776/api/ExAxplineWageConfirm", data);
                Console.WriteLine(result);


            }
        }
        Hashtable map = new Hashtable();
        public string encode(string longUrl)
        {
            longUrl = "http://airport.example.com/";
            string[] urlBody = longUrl.Split('/');
            string urlTail = urlBody[urlBody.Length - 1];
            if (urlTail == "")
                urlTail = " ";
            string urlHead = longUrl.Replace(urlTail, "");
            var hashCode = urlTail.GetHashCode().ToString();
            map.Add(hashCode, urlTail);
            return urlHead + hashCode;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            string[] urlBody = shortUrl.Split('/');
            string urlTail = urlBody[urlBody.Length - 1];
            string urlHead = shortUrl.Replace(urlTail, "");


            if (map.ContainsKey(urlTail))
                urlTail = map[urlTail].ToString();
            if (urlTail == " ")
                urlTail = "";

            return urlHead + urlTail;
        }

        public void TestUpdateAxpline()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var po = db.Select<Ex_axpline>(SqlQuery<Ex_axpline>.Builder().Where(p => p.id == 285995)).FirstOrDefault();

                po.realpiece = 99;
                var poJson = JsonConvert.SerializeObject(po);

                var result = pub.PostDataByUrl("http://localhost:49776/api/PoWffAxpline/UpdateWffAxpline", poJson);

                Console.WriteLine(po);


            }
        }
        /// <summary>
        /// 单独测试po费用更新
        /// </summary>
        public void TestUpdateWffAxplineWage()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcAirexpFreight)))
            {
                var po = db.Select<Ex_axplinewage>(SqlQuery<Ex_axplinewage>.Builder().Where(p => p.id == 4491669)).FirstOrDefault();

                po.num = 99.99M;
                var poJson = JsonConvert.SerializeObject(po);

                var result = pub.PostDataByUrl("http://localhost:49776/api/PoWffAxpline/UpdateWffAxplineWage", poJson);

                Console.WriteLine(po);


            }
        }

        public void TestStoreInsertIntoPo()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcStore)))
            {
                var store = db.Select<EntityModel.Store.Ex_Store>(SqlQuery<EntityModel.Store.Ex_Store>.Builder().Where(p => p.ID == 193522)).FirstOrDefault();


                // var poJson = JsonConvert.SerializeObject(store);

                var result = pub.PostDataByUrl("http://localhost:49776/api/ExStore/PostStoreToPo", store);

                Console.WriteLine(result);




            }
        }

        public void TestUpdateStoreToPo()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcStore)))
            {
                var store = db.Select<EntityModel.Store.Ex_Store>(SqlQuery<EntityModel.Store.Ex_Store>.Builder().Where(p => p.ID == 193522)).FirstOrDefault();

                store.KhJcNo = "ATE32323222";

                var result = pub.PostDataByUrl("http://localhost:49776/api/ExStore/PostStoreToPo", store);

                Console.WriteLine(result);

            }
        }

        public void TestNodeStr()
        {
            string nodeStr = DataByUrl.GetTypeCode(97);
            var nodeLst = pub.ConvertStrToList<NodeView>(nodeStr);
            nodeLst = nodeLst.Where(p => p.ready02 == "0").ToList();
        }


        public void GetPos()
        {
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcPoManagement)))
            {
                var poList = db.Select<Ex_Axpline>(SqlQuery<Ex_Axpline>.Builder().Where(p=>p.id>77&&p.id<90));
                Console.WriteLine(JsonConvert.SerializeObject(poList));
            }
        }
           //var b = { po: [{}, {}], multiplePo: [{ hpo: {}, po: [{}, {}] }] }
        public void GetMultiplePo()
        {
            dynamic json = new ExpandoObject();
            using (var db = new DbBase(pub.GetConfigVal(pub.ConfigList.WcPoManagement)))
            {
                var hpo = db.SelectById<Ex_HpoAxpline>(64);
                var poList = db.Select<Ex_Axpline>(SqlQuery<Ex_Axpline>.Builder().Where(p => p.hpoid ==64));
                json.po = poList;
                json.hpo = hpo;
                Console.WriteLine(JsonConvert.SerializeObject(json));
            }
        }

    }
}
