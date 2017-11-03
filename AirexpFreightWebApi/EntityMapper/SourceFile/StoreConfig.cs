using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PoModel = EntityModel.Po;
using StoreModel = EntityModel.Store;


namespace EntityMapper.SourceFile
{
    public class StoreConfig : Profile
    {

        protected override void Configure()
        {
            CreateMap<StoreModel.Ex_Store, PoModel.Ex_Store>()
                .ForMember(des=>des.id, opt => opt.Ignore())
                .AfterMap((s, d) => { SubstituteNullValue<PoModel.Ex_Store>(d); d.timestamp = 1212323; }); //数据库not null 暂时填个值
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

                if (value == null && item.PropertyType.IsGenericType && item.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    var rootType = item.PropertyType.GetGenericArguments()[0];
                    if (rootType.Name.StartsWith("Int32"))
                    {
                        item.SetValue(t, 0);
                    }
                }

            }
        }
    }
}
