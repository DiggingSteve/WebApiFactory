using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Web.Caching;
using System.Web;

namespace Util
{
    public class ReflectHelper
    {
        private static readonly Cache cache = HttpRuntime.Cache;
        /// <summary>
        /// 获取指定程序集
        /// </summary>
        /// <param name="assemblyString"></param>
        /// <returns></returns>
        public static Assembly GetAssembly(string assemblyString)
        {
            Assembly assembly = cache[assemblyString] as Assembly;
            if (assembly == null)
            {
                assembly = Assembly.Load(assemblyString);
                cache[assemblyString] = assembly;
            }
            return assembly;
        }

        /// <summary>
        /// 获取方法信息
        /// </summary>
        /// <param name="classType"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static MethodInfo GetMethodInfo(Type classType, string methodName)
        {
            var key = string.Format("Method-{0}-{1}", classType.FullName, methodName);
            MethodInfo method = cache[key] as MethodInfo;
            if (method == null)
            {
                method = classType.GetMethod(methodName);
                cache[key] = method;
            }
            return method;
        }

        /// <summary>
        /// 获取指定方法参数
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static ParameterInfo[] GetMethodParamList(Type classType,MethodInfo method)
        {
            var key = string.Format("Para-{0}-{1}", classType.FullName, method.Name);
            ParameterInfo[] parameters = cache[key] as ParameterInfo[];
            if (parameters == null)
            {
                parameters = method.GetParameters();
                cache[key] = parameters;
            }
            return parameters;
        }


        /// <summary>
        /// 获取默认值
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns></returns>
        public static object DefaultForType(Type targetType)
        {
            return targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
        }


    }
}
