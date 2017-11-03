using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.Basic
{  
    /// <summary>
    /// View Model，非实体表 用于接收basic typecode 表的数据
    /// </summary>
   public class NodeView
    {
       public int id { get; set; }

       /// <summary>
       /// group id =97 为wff节点
       /// </summary>
       public int groupid { get; set; }

       public string ready01 { get; set; }
        /// <summary>
        /// ready02 = 0
        /// </summary>
       public string ready02 { get; set; }

       public string ready03 { get; set; }

       public string typename { get; set; }
    }
}
