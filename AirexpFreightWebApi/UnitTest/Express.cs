using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Express
    {


        public Func<string,string> Excute = x => x+"dsdds";





    }

    public static class Test
    {
        public static void T()
        {
            var test = new Express();
            string x = "abcd";
           var result= test.Excute(x);
            Console.WriteLine(result);
        }
    }
}
