using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Util;
using ApiFactory;
using System.Reflection;
using System.Web.Http.Results;
using System.Web.UI.WebControls;
using System.Net;
using ApiFactory.Exception;
using System.Threading.Tasks;

namespace AirexpFreightWebApi.Controllers
{
    public class BaseController : ApiController
    {


        public async Task<object> Post(RequestData request)
        {
            try
            {
                bool flag = true;
                flag = request.CheckParameter();
                if (!flag) throw new InputParamException(request);
                string module = request.Module;
                string domain = request.Domain;
                string methodName = request.Method;
                dynamic data = request.Data;
                var obj = await Process(domain, module, methodName, data);
                return obj;
            }
            catch (Exception e)
            {
                return ProcessException(e);
            }
        }

        private object ProcessException(Exception e)
        {
            if (e is InputParamException)
            {
                return e.ToString();
            }
            else return "未知异常";
        }

        public async Task<object> Process(string domain, string module, string methodName, dynamic data)
        {


            var obj = await Task.Run<object>(() =>
            {
                var apiFact = ReflectHelper.GetAssembly("ApiFactory");
                var instance = apiFact.CreateInstance(string.Format("ApiFactory.{0}.{1}", domain, module), false);
                var type = instance.GetType();
                MethodInfo method = ReflectHelper.GetMethodInfo(type, methodName);
                ParameterInfo[] paras = ReflectHelper.GetMethodParamList(type, method);
                var invokeParams = new List<object>();
                var postParams = PublicClass.PublicClass.ConvertDynToDic(data);
                foreach (var param in paras)
                {
                    invokeParams.Add(postParams[param.Name]);
                }

                return method.Invoke(instance, invokeParams.ToArray());
            });
            return obj;
        }
    }
}