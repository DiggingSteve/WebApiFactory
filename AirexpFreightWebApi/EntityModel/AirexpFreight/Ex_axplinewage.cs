//===============================================================================
// datetime:2017/9/11 15:14:47 
// auth:hzh
//===============================================================================    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace EntityModel.AirexpFreight
{

    public class Ex_axplinewage
    {


        /// <summary>
        ///  
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        ///  上榜工作单ID
        /// </summary> 
        public int sid { get; set; }


        /// <summary>
        ///  服务项目
        /// </summary> 
        public string items { get; set; }


        /// <summary>
        ///  委托客户,供应商ID
        /// </summary> 
        public int gid { get; set; }


        /// <summary>
        ///  参考单价
        /// </summary> 
        public decimal quote { get; set; }


        /// <summary>
        ///  1.应收 2.应付
        /// </summary> 
        public int wageinout { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string wagetype { get; set; }


        /// <summary>
        ///  出处
        /// </summary> 
        public string wagedom { get; set; }


        /// <summary>
        ///  汇率
        /// </summary> 
        public decimal changerate { get; set; }


        /// <summary>
        ///  数量
        /// </summary> 
        public decimal num { get; set; }


        /// <summary>
        ///  币种
        /// </summary> 
        public string currency { get; set; }


        /// <summary>
        ///  单价
        /// </summary> 
        public decimal price { get; set; }


        /// <summary>
        ///  总价
        /// </summary> 
        public decimal wageall { get; set; }


        /// <summary>
        ///  对账金额
        /// </summary> 
        public decimal finishwageall_checkbill { get; set; }


        /// <summary>
        ///  开票金额
        /// </summary> 
        public decimal finishwageall { get; set; }


        /// <summary>
        ///  计算的总价
        /// </summary> 
        public decimal leastwageall { get; set; }


        /// <summary>
        ///  收据金额
        /// </summary> 
        public decimal finishwageall_receipt { get; set; }


        /// <summary>
        ///  账单金额
        /// </summary> 
        public decimal finishwageall_account { get; set; }


        /// <summary>
        ///  应收付账单金额
        /// </summary> 
        public decimal finishwageall_accountinout { get; set; }


        /// <summary>
        ///  核销金额
        /// </summary> 
        public decimal finishwageall_verifiy { get; set; }


        /// <summary>
        ///  对冲核销金额
        /// </summary> 
        public decimal leastwageall_verifiy { get; set; }


        /// <summary>
        ///  发票号(逗号隔开)
        /// </summary> 
        public string invoicecode { get; set; }


        /// <summary>
        ///  收据号(逗号隔开)
        /// </summary> 
        public string receiptcode { get; set; }


        /// <summary>
        ///  账单号(逗号隔开)
        /// </summary> 
        public string accountcode { get; set; }


        /// <summary>
        ///  核销号(逗号隔开)
        /// </summary> 
        public string verifiycode { get; set; }


        /// <summary>
        ///  应收付账单(逗号隔开)
        /// </summary> 
        public string accountinoutcode { get; set; }


        /// <summary>
        ///  是否免费 1.不免, 2.免
        /// </summary> 
        public int isfree { get; set; }


        /// <summary>
        ///  对账状态 1.未对账  900.对账中  1000.已对账
        /// </summary> 
        public int billstatus { get; set; }


        /// <summary>
        ///  对账号
        /// </summary> 
        public string billno { get; set; }


        /// <summary>
        ///  是否确认 1.未确认 700.已确认 800.已提交  1100.已审单 1200. 已审核
        /// </summary> 
        public int confirmstatus { get; set; }


        /// <summary>
        ///  已对账人
        /// </summary> 
        public string confirmman { get; set; }


        /// <summary>
        ///  已对账日期
        /// </summary> 
        public DateTime confirmdate { get; set; }


        /// <summary>
        ///  客户回执确认人
        /// </summary> 
        public string rollbackman { get; set; }


        /// <summary>
        ///  客户回执确认日期
        /// </summary> 
        public DateTime rollbackdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string rollbackremark { get; set; }


        /// <summary>
        ///  财务状态: 1.未开票100.已开票 200.核销中 300.已核销
        /// </summary> 
        public int cwstatus { get; set; }


        /// <summary>
        ///  开票人
        /// </summary> 
        public string invoiceman { get; set; }


        /// <summary>
        ///  开票日期
        /// </summary> 
        public DateTime invoicedate { get; set; }


        /// <summary>
        ///  核销人
        /// </summary> 
        public string hxman { get; set; }


        /// <summary>
        ///  核销日期
        /// </summary> 
        public DateTime hxdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isdel { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string addman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime adddate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string modifyman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime modifydate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string delman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime deldate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string remark { get; set; }


        /// <summary>
        ///  分摊ID , 大于零:分摊数据
        /// </summary> 
        public int isshare { get; set; }


        /// <summary>
        ///  是否待定 1.否 2.是
        /// </summary> 
        public int ispause { get; set; }


        /// <summary>
        ///  对应延伸服务id
        /// </summary> 
        public int sou_sid { get; set; }


        /// <summary>
        ///    收入  支出 对应的id
        /// </summary> 
        public int yid { get; set; }


        /// <summary>
        ///   是否是真实费用    1.计入费用   2.不计入费用
        /// </summary> 
        public int yssys { get; set; }


        /// <summary>
        ///  费用类型
        /// </summary> 
        public string pricetype { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int iscash { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready01 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready02 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready03 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready04 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready05 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready06 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready07 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime ready08 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime ready09 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready10 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isincl { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal reftaxrate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal taxrate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal pricewageall { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal tax { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal revisetax { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal realwageall { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isallin { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ismodify { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int storeid { get; set; }

    }
}
