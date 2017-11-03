using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMapper
{
    public class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<SourceFile.AxplineConfig>();
                cfg.AddProfile<SourceFile.StoreConfig>();
     
            });
        }
    }
}
