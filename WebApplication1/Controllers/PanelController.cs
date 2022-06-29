using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [user_data]
    [RoutePrefix("Panel")]
    public class PanelController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return Content("Welcome To Panel");
        }
    }
}