using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YccospWebApp.Models;
//just adding a comment to see how git works in VS
namespace YccospWebApp.Controllers
{
    public class TimeStampController : Controller
    {
        // GET: TimeStamp
        public ActionResult TimeStampView()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult TimeStampView(TimeStampModel model)
        {

            return View();
            
        }

        
    }
}