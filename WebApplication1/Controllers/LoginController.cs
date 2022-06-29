using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        
        [Route("")]
        public ActionResult Index()
        {
            return View("Login");
        }


        [Route("")]
        [HttpPost]
        public ActionResult Index(string username)
        {
            Response.Cookies.Add(new HttpCookie("user_auth","rezafta"));
            return Redirect("~/Panel");
        }


    }
}