using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFactory.Exception
{
    public class InputParamException : System.Exception
    {
        private string message;// 错误消息
        private RequestData requestDatas;

        public InputParamException(RequestData data)
            : base() // 这边是重写构造函数
        {
            message = "Please checkParam:" + JsonConvert.SerializeObject(data);
            requestDatas = data;
        }
        /// <summary>
        /// 重写异常错误信息
        /// </summary>
        /// <returns></returns>
        public override string ToString() // 重写ToString方法,请看下面override说明
        {
            return message;
        }
        public object ToObject()
        {
            return requestDatas;
        }
    }
}
