using System;
using System.Linq;
using System.Web.Http;

namespace AirexpFreightWebApi
{
    public class RequestAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var authorization = actionContext.Request.Headers.Authorization;
            if ((authorization != null) && (authorization.Scheme != null))
            {
                var encryptTicket = authorization.Scheme;
                if (ValidateTicket(encryptTicket))
                {
                    base.IsAuthorized(actionContext);
                }
                else
                {
                    HandleUnauthorizedRequest(actionContext);
                }
            }
            else
            {
                var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
                var isAnonymous = attributes.Any(a => a != null);
                if (isAnonymous) base.OnAuthorization(actionContext);
                else HandleUnauthorizedRequest(actionContext);
            }
        }

        private bool ValidateTicket(string formsAuthenticationTicket)
        {
            try
            {
                if (formsAuthenticationTicket == null) return false;
                var strTicket = Decode(formsAuthenticationTicket);
                var ticketArray = strTicket.Split('&');
                var company = ticketArray[0];
                if (company != "wecan") return false;
                //var logname = ticketArray[1];
                //var datenow = ticketArray[3];
                //var cacheName = datenow + logname;
                //var sessionLogname = (UserInfo)HttpContext.Current.Cache[cacheName];
                //if (sessionLogname != null) return true;
                // var userInfo = Controllers.UserLoginLogController.GetUserInfo(cacheName, logname);
                // HttpContext.Current.Cache.Insert(cacheName, userInfo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 

        public static string Decode(string str)
        {
            return PublicClass.PublicClass.Decode(str, "WecanWecan");
        }  
    }
}