//===============================================================================
// datetime:2017/9/19 10:45:37 
// auth:YaoDui
//用ado.net 实体模型生成
//===============================================================================    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace EntityModel.AirexpFreight
{
    /// <summary>
    /// 预上榜总单表
    /// </summary>
    public class Ex_AxpPreline
    {


        public int id { get; set; }

        public int oid { get; set; }
        /// <summary>
        /// 预上榜工作号
        /// </summary>
        public string orderno { get; set; }

        /// <summary>
        /// 上榜工作号
        /// </summary>
        public string jobno { get; set; }

        /// <summary>
        ///   订单来源
        /// </summary>
        public string dom { get; set; }

        /// <summary>
        /// 操作类型:1.自货2.代操作
        /// </summary>
        public string czlx { get; set; }

        /// <summary>
        /// 货物性质:1.普货,2.危险品,3.冷冻品
        /// </summary>
        public string hwxz { get; set; }



        /// <summary>
        /// 始发港
        /// </summary>
        public string sfg { get; set; }

        /// <summary>
        /// 目的港
        /// </summary>
        public string mdg { get; set; }

        /// <summary>
        /// 委托件数
        /// </summary>
        public int ybpiece { get; set; }

        /// <summary>
        /// 委托重量
        /// </summary>
        public decimal ybweight { get; set; }

        /// <summary>
        /// 预报体积
        /// </summary>
        public decimal ybvolume { get; set; }

        /// <summary>
        /// 要求航班号
        /// </summary>
        public string yqhbh { get; set; }



        /// <summary>
        ///     总单制作选项  1.正常制作 2.事后补单
        /// </summary>
        public int zdxx { get; set; }

        /// <summary>
        /// 报关选项 1.我司报关 2.客户自报
        /// </summary>
        public string bgxx { get; set; }
        /// <summary>
        /// 中文品名
        /// </summary>
        public string chinesepm { get; set; }

        /// <summary>
        /// 英文品名
        /// </summary>
        public string englishpm { get; set; }

        /// <summary>
        /// 中文品名补充说明
        /// </summary>
        public string chinsepmextend { get; set; }

        /// <summary>
        /// 英文品名补充说明
        /// </summary>
        public string englishpmextend { get; set; }

        /// <summary>
        /// 品名详细描述
        /// </summary>
        public string pmdeclaration { get; set; }

        /// <summary>
        /// 申报类型
        /// </summary>
        public string rendertype { get; set; }

        /// <summary>
        /// 是否磁检报告 1.是2.否
        /// </summary>
        public Nullable<int> ismagnetic { get; set; }
        /// <summary>
        ///  发货代码
        /// </summary>
        public string code_fhr { get; set; }

        /// <summary>
        /// 发货人公司抬头
        /// </summary>
        public string companytitle_fhr { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        public string address_fhr { get; set; }

        /// <summary>
        /// 发货城市
        /// </summary>
        public string city_fhr { get; set; }

        /// <summary>
        ///     发货人邮编
        /// </summary>
        public string postcode_fhr { get; set; }

        /// <summary>
        /// 发货人国家二字码
        /// </summary>
        public string companycode_fhr { get; set; }

        /// <summary>
        ///   发货人国家州名
        /// </summary>
        public string state_fhr { get; set; }

        /// <summary>
        /// 发货联系人
        /// </summary>
        public string lxr_fhr { get; set; }

        /// <summary>
        /// 发货联系人电话
        /// </summary>
        public string phone_fhr { get; set; }

        /// <summary>
        /// 发货联系人email
        /// </summary>
        public string email_fhr { get; set; }

        /// <summary>
        /// 发货人传真
        /// </summary>
        public string fax_fhr { get; set; }

        /// <summary>
        /// 收货代码
        /// </summary>
        public string code_shr { get; set; }

        /// <summary>
        /// 收货公司抬头
        /// </summary>
        public string companytitle_shr { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string address_shr { get; set; }

        /// <summary>
        /// 收货城市
        /// </summary>
        public string city_shr { get; set; }

        /// <summary>
        /// 收货邮编
        /// </summary>
        public string postcode_shr { get; set; }

        /// <summary>
        /// 收货国家二字码
        /// </summary>
        public string companycode_shr { get; set; }

        /// <summary>
        /// 收货国家州名
        /// </summary>
        public string state_shr { get; set; }

        /// <summary>
        /// 收货联系人
        /// </summary>
        public string lxr_shr { get; set; }

        /// <summary>
        /// 收货联系人电话
        /// </summary>
        public string phone_shr { get; set; }

        /// <summary>
        /// 收货联系人email
        /// </summary>
        public string email_shr { get; set; }


        /// <summary>
        /// 收货人传真
        /// </summary>
        public string fax_shr { get; set; }
        public string addman { get; set; }
        public System.DateTime adddate { get; set; }
        public string modifyman { get; set; }
        public Nullable<System.DateTime> modifydate { get; set; }
        public int isdel { get; set; }
        public string delman { get; set; }
        public System.DateTime deldate { get; set; }

        public int timestamp { get; set; }

    }
}
