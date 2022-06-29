using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class user_data : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.Cookies["user_auth"].Value == "rezafta")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}