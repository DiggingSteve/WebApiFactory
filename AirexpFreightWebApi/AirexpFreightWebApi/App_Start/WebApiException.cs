using AirexpFreightWebApi.ExcuteException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using pub = PublicClass;

namespace AirexpFreightWebApi
{
    public class WebApiExceptionAttribute : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            LogHelper.LogHelper.InsertErrorLog<DBNull>(actionExecutedContext.Request, actionExecutedContext.Exception);
            //var exception = actionExecutedContext.Exception;
            //if (actionExecutedContext.Exception is InsertException)
            //{
                 
            //    actionExecutedContext.Response = new HttpResponseMessage 
            //    { 
            //        StatusCode = HttpStatusCode.Accepted,
            //        Content = new StringContent(exception.Message) 
            //    };
            //}
            base.OnException(actionExecutedContext);

        }
    }
}