using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.Po
{
  public  class Ex_Store
    {
        public int id { get; set; }
        public string gzdno { get; set; }
        public string storename { get; set; }
        public System.DateTime jcdate { get; set; }
        public string jcno { get; set; }
        public string khjcno { get; set; }
        public string hzdno { get; set; }
        public Nullable<int> breakpiece { get; set; }
        public Nullable<int> moistpiece { get; set; }
        public Nullable<int> deformpiece { get; set; }
        public Nullable<int> arrowpiece { get; set; }
        public Nullable<int> dangerpiece { get; set; }
        public string otherbreakinfo { get; set; }
        public int allpiece { get; set; }
        public Nullable<int> lpiece { get; set; }
        public decimal allweight { get; set; }
        public decimal allvolume { get; set; }
        public int hwstatus { get; set; }
        public Nullable<int> timestamp { get; set; }
    }
}
