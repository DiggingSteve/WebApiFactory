using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EntityModel.AirexpFreight;
using EntityModel.Po;

namespace EntityMapper.SourceFile
{
    public class AxplineConfig : Profile
    {
        protected override void Configure()
        {
            CreateMap<Ex_Axpline, Ex_AxpPreline>()
                .ForMember(des=>des.id,opt=>opt.Ignore())
                .ForMember(des => des.hwxz, opt => opt.MapFrom(src => src.hwlx))   //wff货物性质 ,po货物类型
                .ForMember(des => des.sfg, opt => opt.MapFrom(src => src.yqsfg))//始发港 ,要求始发港
                .ForMember(des => des.bgxx, opt => opt.MapFrom(src => src.bgfs))//报关选项 ,报关方式
                .ForMember(des => des.oid, opt => opt.MapFrom(src => src.id))//po id 等于pre的oid
                .AfterMap((po, wff) => SubstituteNullValue<Ex_AxpPreline>(wff));

            CreateMap<Ex_HpoAxpline, Ex_AxpPreline>()
                .ForMember(des => des.id, opt => opt.Ignore())
                .ForMember(des => des.hwxz, opt => opt.MapFrom(src => src.hwlx))   //wff货物性质 ,po货物类型
                .ForMember(des => des.sfg, opt => opt.MapFrom(src => src.yqsfg))//始发港 ,要求始发港
                .ForMember(des => des.bgxx, opt => opt.MapFrom(src => src.bgfs))//报关选项 ,报关方式
                .ForMember(des => des.oid, opt => opt.MapFrom(src => src.id))//po id 等于pre的oid
                .AfterMap((po, wff) => { SubstituteNullValue<Ex_AxpPreline>(wff); wff.dom = "HPO"; });


            CreateMap<Ex_AxpPreline, Ex_AxpPrelineHawb>()
                .ForMember(des => des.id, opt => opt.Ignore())
                .ForMember(des => des.sid, opt => opt.MapFrom(src => src.id))  //分单sid==主单id
                .AfterMap((wffPre, wffHawb) => SubstituteNullValue<Ex_AxpPrelineHawb>(wffHawb));

   




        }
        /// <summary>
        ///转换完成后将 null类型转换为默认类型
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="t"></param>
        /// <param name="replaceValue"></param>
        public void SubstituteNullValue<TSource>(TSource t)
        {
            var attList = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (System.Reflection.PropertyInfo item in attList)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);

                if (value == null && item.PropertyType.Name.StartsWith("String"))
                {
                    item.SetValue(t, string.Empty);
                }

             

            }
        }
    }
}
