using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.AirexpFreight
{
    /// <summary>
    /// 预上榜分单
    /// </summary>
    public class Ex_AxpPrelineHawb
    {

        public int id { get; set; }
        public int? sid { get; set; }
        public string hpono { get; set; }
        public string dom { get; set; }
        public int? gid { get; set; }
        public string hawb { get; set; }
        public Nullable<System.DateTime> dzarriverq { get; set; }
        public string yqsfg { get; set; }
        public string mdg { get; set; }
        public string yqhbh { get; set; }
        public Nullable<System.DateTime> yqhbrq { get; set; }
        public int? ybpiece { get; set; }
        public decimal? ybweight { get; set; }
        public decimal? ybvolume { get; set; }
        public string tradeterm { get; set; }
        public string czremark { get; set; }
        public string otherremark { get; set; }
        public string area { get; set; }
        public string system { get; set; }
        public int? status { get; set; }
        public string hwlx { get; set; }
        public string pm { get; set; }
        public string khjcno { get; set; }
        public string bgfs { get; set; }
        public Nullable<System.DateTime> yjjcdate { get; set; }
        public Nullable<System.DateTime> jhjcdate { get; set; }
        public decimal? inwageallinprice { get; set; }
        public int? isinwageallin { get; set; }
        public decimal? self_real_bp_freight_in { get; set; }
        public decimal? cus_real_bp_freight_in { get; set; }
        public string address_thr { get; set; }
        public string lxr_thr { get; set; }
        public string phone_thr { get; set; }
        public string address_shr { get; set; }
        public string lxr_shr { get; set; }
        public string phone_shr { get; set; }

        public string code_fhr_mawb { get; set; }
        public string companytitle_fhr_mawb { get; set; }
        public string address_fhr_mawb { get; set; }
        public string city_fhr_mawb { get; set; }
        public string postcode_fhr_mawb { get; set; }
        public string companycode_fhr_mawb { get; set; }
        public string state_fhr_mawb { get; set; }
        public string lxr_fhr_mawb { get; set; }
        public string phone_fhr_mawb { get; set; }
        public string email_fhr_mawb { get; set; }
        public string fax_fhr_mawb { get; set; }
        public string code_shr_mawb { get; set; }
        public string companytitle_shr_mawb { get; set; }
        public string address_shr_mawb { get; set; }
        public string city_shr_mawb { get; set; }
        public string postcode_shr_mawb { get; set; }
        public string companycode_shr_mawb { get; set; }
        public string state_shr_mawb { get; set; }
        public string lxr_shr_mawb { get; set; }
        public string phone_shr_mawb { get; set; }
        public string email_shr_mawb { get; set; }
        public string fax_shr_mawb { get; set; }

        public string addman { get; set; }
        public Nullable<System.DateTime> adddate { get; set; }
        public string modifyman { get; set; }
        public Nullable<System.DateTime> modifydate { get; set; }
        public string delman { get; set; }
        public Nullable<System.DateTime> deldate { get; set; }
        public int? isdel { get; set; }
        public string assignman { get; set; }
        public Nullable<System.DateTime> assigndate { get; set; }
        private int timestamp { get; set; }




    }
}
