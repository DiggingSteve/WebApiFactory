//===============================================================================
// datetime:2017/9/6 14:26:00 
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


    public  class Ex_axpline  
    {


        /// <summary>
        ///  
        /// </summary> 
        public int id { get; set; }


        /// <summary>
        ///  上榜工作号
        /// </summary> 
        public string jobno { get; set; }


        /// <summary>
        ///  预上榜工作号
        /// </summary> 
        public string jobnoy { get; set; }


        /// <summary>
        ///  操作类型:1.自货2.代操作
        /// </summary> 
        public string czlx { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int gid { get; set; }


        /// <summary>
        ///  货物性质:1.普货,2.危险品,3.冷冻品
        /// </summary> 
        public string hwxz { get; set; }


        /// <summary>
        ///  业务类型 1.正常业务 2.单独提交
        /// </summary> 
        public string ywlx { get; set; }


        /// <summary>
        ///  货物操作 仓库收货(普) 外仓提货(普) 安检机前接货 安检机后接货 自操作有交接
        /// </summary> 
        public string hwcz { get; set; }


        /// <summary>
        ///  货型类型 1.同行货 2.海外代理货
        /// </summary> 
        public string hxlx { get; set; }


        /// <summary>
        ///  收入合约
        /// </summary> 
        public string srhy { get; set; }


        /// <summary>
        ///  客户进仓编号
        /// </summary> 
        public string khjcbh { get; set; }


        /// <summary>
        ///  预报件数
        /// </summary> 
        public int ybpiece { get; set; }


        /// <summary>
        ///  预报重量
        /// </summary> 
        public decimal ybweight { get; set; }


        /// <summary>
        ///  预报体积
        /// </summary> 
        public decimal ybvolume { get; set; }


        /// <summary>
        ///  实际件数
        /// </summary> 
        public int realpiece { get; set; }


        /// <summary>
        ///  实际重量
        /// </summary> 
        public decimal realweight { get; set; }


        /// <summary>
        ///  实际体积
        /// </summary> 
        public decimal realvolume { get; set; }


        /// <summary>
        ///  是否超限 1.未超限 2.超限
        /// </summary> 
        public int iscx { get; set; }


        /// <summary>
        ///  是否为空号 1.是 2.否
        /// </summary> 
        public int iskh { get; set; }


        /// <summary>
        ///  空号是否已补 1.是 2.否
        /// </summary> 
        public int iskhset { get; set; }


        /// <summary>
        ///  制单件数
        /// </summary> 
        public int zdpiece { get; set; }


        /// <summary>
        ///  制单重量
        /// </summary> 
        public decimal zdweight { get; set; }


        /// <summary>
        ///  制单体积
        /// </summary> 
        public decimal zdvolume { get; set; }


        /// <summary>
        ///  小件数
        /// </summary> 
        public int smallpiece { get; set; }


        /// <summary>
        ///  报关重量
        /// </summary> 
        public decimal bgweight { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string bzzl { get; set; }


        /// <summary>
        ///  尺寸备注
        /// </summary> 
        public string ccremark { get; set; }


        /// <summary>
        ///  始发港
        /// </summary> 
        public string sfg { get; set; }


        /// <summary>
        ///  总单目的港
        /// </summary> 
        public string mawbmdg { get; set; }


        /// <summary>
        ///  总单目的港名称
        /// </summary> 
        public string hawbmdg { get; set; }


        /// <summary>
        ///  中文品名
        /// </summary> 
        public string chinesepm { get; set; }


        /// <summary>
        ///  预计到货仓库 1.305库 2.晨阳路库
        /// </summary> 
        public string yjstore { get; set; }


        /// <summary>
        ///  预计到货时间
        /// </summary> 
        public DateTime? yjstoredate { get; set; }


        /// <summary>
        ///  是否现场 1.是 2.否
        /// </summary> 
        public int isxc { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string volumeinfo { get; set; }


        /// <summary>
        ///  航班号
        /// </summary> 
        public string hbh { get; set; }


        /// <summary>
        ///  航班日期
        /// </summary> 
        public DateTime? hbrq { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? hbrq_qfsj { get; set; }


        /// <summary>
        ///  航班时间类型 1.早班机 2.中班机 3.晚班机
        /// </summary> 
        public string hbtype { get; set; }


        /// <summary>
        ///  运输条件 1.普运 2.普快 3.特快
        /// </summary> 
        public string ystj { get; set; }


        /// <summary>
        ///  运输服务方式 1.直达 2.中转 
        /// </summary> 
        public string ysfwfs { get; set; }


        /// <summary>
        ///  运程天数
        /// </summary> 
        public decimal ycts { get; set; }


        /// <summary>
        ///  指定航班号 1.指定 2.未指定
        /// </summary> 
        public int iszdhbh { get; set; }


        /// <summary>
        ///  指定航空公司 1.指定 2.未指定
        /// </summary> 
        public int iszdaircompany { get; set; }


        /// <summary>
        ///  中转港
        /// </summary> 
        public string zzg { get; set; }


        /// <summary>
        ///  操作部门ID
        /// </summary> 
        public int czdeptid { get; set; }


        /// <summary>
        ///  总单号
        /// </summary> 
        public string mawb { get; set; }


        /// <summary>
        ///  总单号锁定 1.未锁定 2.已锁定
        /// </summary> 
        public int ismawbsd { get; set; }


        /// <summary>
        ///  总单付费方式 1.PP 2.CC
        /// </summary> 
        public string mawbfffs { get; set; }


        /// <summary>
        ///  总单制作选项  1.正常制作 2.事后补单
        /// </summary> 
        public string mawbzzxx { get; set; }


        /// <summary>
        ///  分单制作选项:我司分运单,客户运分单,不出分运单
        /// </summary> 
        public string hawbselect { get; set; }


        /// <summary>
        ///  我司分单号
        /// </summary> 
        public string hawb { get; set; }


        /// <summary>
        ///  分单信息-发货人code
        /// </summary> 
        public int fhrid { get; set; }


        /// <summary>
        ///  分单信息-发货人名称
        /// </summary> 
        public string fhrname_f { get; set; }


        /// <summary>
        ///  分单信息-发货人地址1
        /// </summary> 
        public string fhraddress1_f { get; set; }


        /// <summary>
        ///  分单信息-发货人地址2
        /// </summary> 
        public string fhraddress2_f { get; set; }


        /// <summary>
        ///  分单信息-发货人地址3
        /// </summary> 
        public string fhraddress3_f { get; set; }


        /// <summary>
        ///  分单信息-发货人地址4
        /// </summary> 
        public string fhraddress4_f { get; set; }


        /// <summary>
        ///  分单信息-发货人地址5
        /// </summary> 
        public string fhraddress5_f { get; set; }


        /// <summary>
        ///  分单信息-收货人code
        /// </summary> 
        public string shrcode_f { get; set; }


        /// <summary>
        ///  分单信息-收货人名称
        /// </summary> 
        public string shrname_f { get; set; }


        /// <summary>
        ///  分单信息-收货人地址1
        /// </summary> 
        public string shraddress1_f { get; set; }


        /// <summary>
        ///  分单信息~收货人地址2
        /// </summary> 
        public string shraddress2_f { get; set; }


        /// <summary>
        ///  分单信息~收货人地址3
        /// </summary> 
        public string shraddress3_f { get; set; }


        /// <summary>
        ///  分单信息~收货人地址4
        /// </summary> 
        public string shraddress4_f { get; set; }


        /// <summary>
        ///  分单信息-收货人地址5
        /// </summary> 
        public string shraddress5_f { get; set; }


        /// <summary>
        ///  分单信息-件数
        /// </summary> 
        public int piece_f { get; set; }


        /// <summary>
        ///  分单信息-重量
        /// </summary> 
        public decimal weight_f { get; set; }


        /// <summary>
        ///  分单信息-体积
        /// </summary> 
        public decimal volume_f { get; set; }


        /// <summary>
        ///  分单信息-运费方式 1.PP 2.CC
        /// </summary> 
        public string yffs_f { get; set; }


        /// <summary>
        ///  分单信息-杂费方式 1.PP 2.CC
        /// </summary> 
        public string zffs_f { get; set; }


        /// <summary>
        ///  报关供应商ID
        /// </summary> 
        public int bggysid { get; set; }


        /// <summary>
        ///  报关文件到单时间
        /// </summary> 
        public DateTime? bgwjdate { get; set; }


        /// <summary>
        ///  报关选项 1.我司报关 2.客户报关
        /// </summary> 
        public string bgxx { get; set; }


        /// <summary>
        ///  报关类型
        /// </summary> 
        public string bglx { get; set; }


        /// <summary>
        ///  是否单证收齐 1.是 2.否
        /// </summary> 
        public int isdzsq { get; set; }


        /// <summary>
        ///  单证收齐时间
        /// </summary> 
        public DateTime? dzsqdate { get; set; }


        /// <summary>
        ///  是否单证后补 1.是 2.否
        /// </summary> 
        public int isdzhb { get; set; }


        /// <summary>
        ///  是否货已到齐 1.是 2.否
        /// </summary> 
        public int ishydq { get; set; }


        /// <summary>
        ///  运价类型 1.临时运价 2.固定运价 3.协议运价
        /// </summary> 
        public string yjtype { get; set; }


        /// <summary>
        ///  运价方式 1.单价 2.总价
        /// </summary> 
        public string yjfs { get; set; }


        /// <summary>
        ///  运价
        /// </summary> 
        public decimal yjprice { get; set; }


        /// <summary>
        ///  杂费是否锁定(航线应收) 1.是 2.否
        /// </summary> 
        public int lockwagein { get; set; }


        /// <summary>
        ///  杂费是否锁定(航线应付) 1.是 2.否
        /// </summary> 
        public int lockwageout { get; set; }


        /// <summary>
        ///  结算重量(应收)
        /// </summary> 
        public decimal accountweightin { get; set; }


        /// <summary>
        ///  结算重量(应付)
        /// </summary> 
        public decimal accountweightout { get; set; }


        /// <summary>
        ///  结算重量_结算(应收)
        /// </summary> 
        public decimal accountweightin_sett { get; set; }


        /// <summary>
        ///  结算重量_结算(应付)
        /// </summary> 
        public decimal accountweightout_sett { get; set; }


        /// <summary>
        ///  结算重量(应收)
        /// </summary> 
        public decimal accountweightin_trans { get; set; }


        /// <summary>
        ///  结算重量(应付)
        /// </summary> 
        public decimal accountweightout_trans { get; set; }


        /// <summary>
        ///  吃重比
        /// </summary> 
        public decimal absoweight { get; set; }


        /// <summary>
        ///  吃泡比
        /// </summary> 
        public decimal absovolume { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal jfweightin { get; set; }


        /// <summary>
        ///  操作费类型 1.协议操作费 2.临时操作费
        /// </summary> 
        public string czftype { get; set; }


        /// <summary>
        ///  操作费方式
        /// </summary> 
        public string czffs { get; set; }


        /// <summary>
        ///  操作费
        /// </summary> 
        public decimal czfprice { get; set; }


        /// <summary>
        ///  杂费是否锁定(航线) 1.是 2.否
        /// </summary> 
        public string zftype { get; set; }


        /// <summary>
        ///  杂费
        /// </summary> 
        public decimal zfprice { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int price_type_in { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int price_type_out { get; set; }


        /// <summary>
        ///  协议名称_应收
        /// </summary> 
        public string agree_code_in { get; set; }


        /// <summary>
        ///  协议名称_应付
        /// </summary> 
        public string agree_code_out { get; set; }


        /// <summary>
        ///  我司_协议_分泡_运费_应收
        /// </summary> 
        public decimal self_agree_bp_freight_in { get; set; }


        /// <summary>
        ///  我司_协议_分泡_运费_应付
        /// </summary> 
        public decimal self_agree_bp_freight_out { get; set; }


        /// <summary>
        ///  我司_协议_分泡_中转费_应收
        /// </summary> 
        public decimal self_agree_bp_trans_in { get; set; }


        /// <summary>
        ///  我司_协议_分泡_中转费_应付
        /// </summary> 
        public decimal self_agree_bp_trans_out { get; set; }


        /// <summary>
        ///  我司_实际_分泡_运费_应收
        /// </summary> 
        public decimal self_real_bp_freight_in { get; set; }


        /// <summary>
        ///  我司_实际_分泡_运费_应付
        /// </summary> 
        public decimal self_real_bp_freight_out { get; set; }


        /// <summary>
        ///  我司_实际_分泡_中转费_应收
        /// </summary> 
        public decimal self_real_bp_trans_in { get; set; }


        /// <summary>
        ///  我司_实际_分泡_中转费_应付
        /// </summary> 
        public decimal self_real_bp_trans_out { get; set; }


        /// <summary>
        ///  客户_协议_分泡_运费_应收
        /// </summary> 
        public decimal cus_agree_bp_freight_in { get; set; }


        /// <summary>
        ///  我司_协议_分泡_运费_应付
        /// </summary> 
        public decimal cus_agree_bp_freight_out { get; set; }


        /// <summary>
        ///  客户_协议_分泡_中转费_应收
        /// </summary> 
        public decimal cus_agree_bp_trans_in { get; set; }


        /// <summary>
        ///  客户_协议_分泡_中转费_应付
        /// </summary> 
        public decimal cus_agree_bp_trans_out { get; set; }


        /// <summary>
        ///  客户_实际_分泡_运费_应收
        /// </summary> 
        public decimal cus_real_bp_freight_in { get; set; }


        /// <summary>
        ///  客户_实际_分泡_运费_应付
        /// </summary> 
        public decimal cus_real_bp_freight_out { get; set; }


        /// <summary>
        ///  客户_实际_分泡_中转费_应收
        /// </summary> 
        public decimal cus_real_bp_trans_in { get; set; }


        /// <summary>
        ///  客户_实际_分泡_中转费_应付
        /// </summary> 
        public decimal cus_real_bp_trans_out { get; set; }


        /// <summary>
        ///  是否包含交接地费用_应收
        /// </summary> 
        public int is_handing_in { get; set; }


        /// <summary>
        ///  是否包含交接地费用_应付
        /// </summary> 
        public int is_handing_out { get; set; }


        /// <summary>
        ///  1.开口 2.闭口
        /// </summary> 
        public int packagevolume_type { get; set; }


        /// <summary>
        ///  我司分泡(收入)
        /// </summary> 
        public string xyfz { get; set; }


        /// <summary>
        ///  客户分泡(收入)
        /// </summary> 
        public string xyfp { get; set; }


        /// <summary>
        ///  我司分泡(成本)
        /// </summary> 
        public string khfz { get; set; }


        /// <summary>
        ///  客户分泡(成本)
        /// </summary> 
        public string khfp { get; set; }


        /// <summary>
        ///  我司分重(收入)
        /// </summary> 
        public string xyfz_weight { get; set; }


        /// <summary>
        ///  客户分重(收入)
        /// </summary> 
        public string xyfp_weight { get; set; }


        /// <summary>
        ///  我司分重(成本)
        /// </summary> 
        public string khfz_weight { get; set; }


        /// <summary>
        ///  客户分重(成本)
        /// </summary> 
        public string khfp_weight { get; set; }


        /// <summary>
        ///  签约部门
        /// </summary> 
        public string qydept { get; set; }


        /// <summary>
        ///  是否提交结算 1.否 2.是
        /// </summary> 
        public int istoaccount { get; set; }


        /// <summary>
        ///  有无照片 1.有照片 2.无照片
        /// </summary> 
        public int isphoto { get; set; }


        /// <summary>
        ///  预警状态 1.未预警 2.已预警
        /// </summary> 
        public int yjstatus { get; set; }


        /// <summary>
        ///  配舱状态 1.航线未确认 2.未配舱 3.已配舱 4.航线删 5.外场拉货 6.暂停
        /// </summary> 
        public int pcstatus { get; set; }


        /// <summary>
        ///  报关状态 1.正收单 100.可报关 200.正报关 300.一放通过 400.查验中 500.查验放行 600.航单已核 700.退单完成 800.退单清返
        /// </summary> 
        public int bgstatus { get; set; }


        /// <summary>
        ///  航线要求/签单要求
        /// </summary> 
        public string hxyq { get; set; }


        /// <summary>
        ///  单证要求/分单制作要求
        /// </summary> 
        public string dzyq { get; set; }


        /// <summary>
        ///  单证要求/总单制作要求
        /// </summary> 
        public string dzmawbyq { get; set; }


        /// <summary>
        ///  仓库要求/标签要求
        /// </summary> 
        public string storeyq { get; set; }


        /// <summary>
        ///  结算要求
        /// </summary> 
        public string accountyq { get; set; }


        /// <summary>
        ///  外场拉货要求
        /// </summary> 
        public string wclhyq { get; set; }


        /// <summary>
        ///  报关要求
        /// </summary> 
        public string bgyq { get; set; }


        /// <summary>
        ///  报关要求
        /// </summary> 
        public string bqyq { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string salesman { get; set; }


        /// <summary>
        ///  报关文件数量
        /// </summary> 
        public int bgwnum { get; set; }


        /// <summary>
        ///  报关文件备注
        /// </summary> 
        public string bgwjremark { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int hxdwjsl { get; set; }


        /// <summary>
        ///  核销单文件备注
        /// </summary> 
        public string hxdwjremark { get; set; }


        /// <summary>
        ///  手册文件数量
        /// </summary> 
        public int scwjsl { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string scwjremark { get; set; }


        /// <summary>
        ///  商检文件数量
        /// </summary> 
        public int sjwjsl { get; set; }


        /// <summary>
        ///  商检文件备注
        /// </summary> 
        public string sjwjremark { get; set; }


        /// <summary>
        ///  许可证文件数量
        /// </summary> 
        public int xkzwjsl { get; set; }


        /// <summary>
        ///  许可证文件备注
        /// </summary> 
        public string xkzwjremark { get; set; }


        /// <summary>
        ///  其他文件数量
        /// </summary> 
        public int otherwjsl { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string otherwjremark { get; set; }


        /// <summary>
        ///  是否导入制单 1.否 2.是
        /// </summary> 
        public int istozd { get; set; }


        /// <summary>
        ///  上榜来源 1.客户 2.客服 3.航线 4.销售 5.其他
        /// </summary> 
        public string axplinesource { get; set; }


        /// <summary>
        ///  备注
        /// </summary> 
        public string remark { get; set; }


        /// <summary>
        ///  总运单标签制作 1.制作 2.不制作
        /// </summary> 
        public int ismawbbqzz { get; set; }


        /// <summary>
        ///  分运单标签制作 1.制作 2.不制作
        /// </summary> 
        public int ishawbbqzz { get; set; }


        /// <summary>
        ///  拼货要求 1.可拼 2.不可拼
        /// </summary> 
        public int isphyq { get; set; }


        /// <summary>
        ///  海外代理ID
        /// </summary> 
        public int hwdlid { get; set; }


        /// <summary>
        ///  拼货汇总号
        /// </summary> 
        public string phno { get; set; }


        /// <summary>
        ///  舱位ID
        /// </summary> 
        public int cwid { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string sourcemawb { get; set; }


        /// <summary>
        ///  换总单操作人
        /// </summary> 
        public string cngmawbczr { get; set; }


        /// <summary>
        ///  换总单操作日期
        /// </summary> 
        public DateTime? cngmawbczdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string sourcehawb { get; set; }


        /// <summary>
        ///  换分单操作人
        /// </summary> 
        public string cnghawbczr { get; set; }


        /// <summary>
        ///  换分单操作日期
        /// </summary> 
        public DateTime? cnghawbczdate { get; set; }


        /// <summary>
        ///  头程离港 1.未离港 2.已离港
        /// </summary> 
        public int firleavestatus { get; set; }


        /// <summary>
        ///  二程到达 1.未到达 2.已到达
        /// </summary> 
        public int secgetstatus { get; set; }


        /// <summary>
        ///  操作流转单预配人
        /// </summary> 
        public string czlzdaddypr { get; set; }


        /// <summary>
        ///  操作流转单制作人
        /// </summary> 
        public string czlzdaddr { get; set; }


        /// <summary>
        ///  操作流转单制作日期
        /// </summary> 
        public DateTime? czlzdadddate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string czlzdmodifier { get; set; }


        /// <summary>
        ///  操作流转单修改日期
        /// </summary> 
        public DateTime? czlzdmodifydate { get; set; }


        /// <summary>
        ///  操作流转单打印状态 1.未打印 2.已打印
        /// </summary> 
        public int czlzdprintstatus { get; set; }


        /// <summary>
        ///  操作流转单打印人
        /// </summary> 
        public string czlzdprintr { get; set; }


        /// <summary>
        ///  操作流转单打印日期
        /// </summary> 
        public DateTime? czlzdprintdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string czlzdremark { get; set; }


        /// <summary>
        ///  单证状态 1.上榜未确认 100.上榜已确认 200.签单申请 300.签单确认 400.操作单已制 500.签单待修改 600.分运单已制 700.总运单已制 800.对账中 900.已对账 1000.已提交 1100.已审单 1200.已审核
        /// </summary> 
        public int dzstatus { get; set; }


        /// <summary>
        ///  分隔符
        /// </summary> 
        public string splitstring { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string addman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? adddate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string modifyman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? modifydate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string delman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? deldate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isdel { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string delreason { get; set; }


        /// <summary>
        ///  申请签单人
        /// </summary> 
        public string submitqdman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? submitqddate { get; set; }


        /// <summary>
        ///  签单人
        /// </summary> 
        public string qdman { get; set; }


        /// <summary>
        ///  签单日期
        /// </summary> 
        public DateTime? qddate { get; set; }


        /// <summary>
        ///  ams状态: 1.未制作 2.已制作
        /// </summary> 
        public int amsstatus { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string amsaddman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? amsadddate { get; set; }


        /// <summary>
        ///  航线签单待修改 状态   1.无 2.不可修改(上面) 3.可修改(上面)
        /// </summary> 
        public int commbillmodifystatus { get; set; }


        /// <summary>
        ///  可装车状态 1.无 2.可装车 3.已装车
        /// </summary> 
        public int trackstatus { get; set; }


        /// <summary>
        ///  航线删状态 1.删除 2.未删除
        /// </summary> 
        public int hxdelstatus { get; set; }


        /// <summary>
        ///  航线删原因
        /// </summary> 
        public string hxdelreason { get; set; }


        /// <summary>
        ///  航线删除人
        /// </summary> 
        public string hxdelman { get; set; }


        /// <summary>
        ///  航线删除日期
        /// </summary> 
        public DateTime? hxdeldate { get; set; }


        /// <summary>
        ///  应收对账状态 1.未对账  900.对账中  1000.已对账
        /// </summary> 
        public int billstatus_in { get; set; }


        /// <summary>
        ///  应付对账状态 1.未对账  900.对账中  1000.已对账
        /// </summary> 
        public int billstatus_out { get; set; }


        /// <summary>
        ///  提交财务人
        /// </summary> 
        public string submitman_1_sett { get; set; }


        /// <summary>
        ///  提交财务日期
        /// </summary> 
        public DateTime? submitdate_1_sett { get; set; }


        /// <summary>
        ///  财务提交经理人
        /// </summary> 
        public string submitman_2_sett { get; set; }


        /// <summary>
        ///  财务提交经理日期
        /// </summary> 
        public DateTime? submitdate_2_sett { get; set; }


        /// <summary>
        ///  审核人
        /// </summary> 
        public string examineman_sett { get; set; }


        /// <summary>
        ///  审核日期
        /// </summary> 
        public DateTime? examinedate_sett { get; set; }


        /// <summary>
        ///  1 无  2 审单驳回   3 审单重新确认
        /// </summary> 
        public int examineisback_sett { get; set; }


        /// <summary>
        ///  审核备注
        /// </summary> 
        public string examineremark_sett { get; set; }


        /// <summary>
        ///  核算卡制作状态 1.未制作 2.已制作
        /// </summary> 
        public int accountstatus { get; set; }


        /// <summary>
        ///  核算卡制作人
        /// </summary> 
        public string accountman { get; set; }


        /// <summary>
        ///  核算卡制作日期
        /// </summary> 
        public DateTime? accountdate { get; set; }


        /// <summary>
        ///  是否为我司制单代理code  1.我司 2.非我司
        /// </summary> 
        public int iszddl { get; set; }


        /// <summary>
        ///  制单代理代码
        /// </summary> 
        public string zddlcode { get; set; }


        /// <summary>
        ///  实际地面代理供应商 1.是 2.否
        /// </summary> 
        public int isdmdlgys { get; set; }


        /// <summary>
        ///  是否导入(用友) 1.是 2.否
        /// </summary> 
        public int isexport { get; set; }


        /// <summary>
        ///  导入(用友)人
        /// </summary> 
        public string exportman { get; set; }


        /// <summary>
        ///  导入(用友)日期
        /// </summary> 
        public DateTime? exportdate { get; set; }


        /// <summary>
        ///  亏损原因
        /// </summary> 
        public string lossreason { get; set; }


        /// <summary>
        ///  是否设置结算日期 1.是 2.否
        /// </summary> 
        public int issett { get; set; }


        /// <summary>
        ///  设置结算人
        /// </summary> 
        public string settman { get; set; }


        /// <summary>
        ///  设置结算日期
        /// </summary> 
        public DateTime? settdate { get; set; }


        /// <summary>
        ///  设置结算日期(系统)
        /// </summary> 
        public DateTime? settsysdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isinwageallin { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isoutwageallin { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal inwageallinprice { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal outwageallinprice { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isinwageallin_trans { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isoutwageallin_trans { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal inwageallinprice_trans { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal outwageallinprice_trans { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int hawbnum { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ishawbnummodify { get; set; }


        /// <summary>
        ///  报关票数
        /// </summary> 
        public int bgnum { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isbgnummodify { get; set; }


        /// <summary>
        ///  待通过节点 1.上榜 100.签单
        /// </summary> 
        public int creditnode { get; set; }


        /// <summary>
        ///  信控驳回状态  1 无  2 驳回   3 重新确认
        /// </summary> 
        public int creditisbackstatus { get; set; }


        /// <summary>
        ///  信控内容
        /// </summary> 
        public string creditcontent { get; set; }


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
        public string ready05 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready06 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready07 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready08 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready09 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready10 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready11 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready12 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready13 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready14 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready15 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready16 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready17 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready18 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready19 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready20 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready21 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready22 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready23 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready24 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready25 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready26 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready27 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready28 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready29 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int ready30 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready31 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready32 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready33 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready34 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready35 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready36 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready37 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready38 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready39 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready40 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready41 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready42 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready43 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready44 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready45 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready46 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready47 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready48 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready49 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready50 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready51 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready52 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready53 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready54 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready55 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready56 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready57 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready58 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready59 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready60 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready61 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready62 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready63 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready64 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready65 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready66 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready67 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready68 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready69 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready70 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready71 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready72 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready73 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready74 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready75 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready76 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready77 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready78 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready79 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string ready80 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready81 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready82 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready83 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready84 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready85 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready86 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready87 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready88 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready89 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready90 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready91 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready92 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready93 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready94 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready95 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready96 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready97 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready98 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready99 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal ready100 { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string kfyq { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string storeyq_out { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string salesjobno { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string customername { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string customerjobno { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string cwlxr { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string khname { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string khphone { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string khmobile { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string khfax { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string submitman_out_sett { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? submitdate_out_sett { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string relatedDom { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string relatedJobno { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string relatedArea { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string pono { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string accman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? accdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string connman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? conndate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? arrivedate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string confirmman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? confirmdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int Accountweightin_type { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int Accountweightin_trans_type { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int Accountweightout_type { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int Accountweightout_trans_type { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int isconfirmletter { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string Freightfee_remark { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string pcman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? pcdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string lockman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? lockdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public int tgstatus { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public DateTime? tgdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string tgman { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string bllx { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string bllxcountry { get; set; }


        /// <summary>
        ///   安全声明打印状态(1.已打 2.未打)
        /// </summary> 
        public int letterstatus { get; set; }


        /// <summary>
        ///  打印人
        /// </summary> 
        public string letterman { get; set; }


        /// <summary>
        ///   打印日期
        /// </summary> 
        public DateTime? etterdate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string inwageallcurrency { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal inwageallchangerate { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public string outwageallcurrency { get; set; }


        /// <summary>
        ///  
        /// </summary> 
        public decimal outwageallchangerate { get; set; }

    }
}
