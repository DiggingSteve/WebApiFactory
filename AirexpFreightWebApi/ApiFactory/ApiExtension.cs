using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFactory
{
    public static class ApiExtension
    {
        public static bool CheckParameter(this RequestData request)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(request.Module))
                flag = false;
             if (string.IsNullOrEmpty(request.Domain))
                flag = false;
             if (request.Data == null)
                flag = false;
             if (string.IsNullOrEmpty(request.Method))
                 flag = false;

            return flag;

        }
    }
}