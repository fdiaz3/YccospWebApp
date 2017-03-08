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
            TimeStampModel clock = new TimeStampModel(); 
            return View(clock);
        }

        
        public ActionResult TrackTime(TimeStampModel model)
        {
            
            if (model.timer.IsRunning)
            {
                throw new InvalidOperationException("Time is already being tracking.");
            }
            model.timer.Restart();
            return View(model);
            
        }

        [HttpGet]
        public ActionResult RecordTime(TimeStampModel model)
        {
            
            if (model.timer.IsRunning)
            {
                model.timer.Stop();
                model.totalTime = model.totalTime.Add(model.timer.Elapsed);
            }
            else
            {
                throw new InvalidOperationException("Time tracking is currently stopped.");
            }
            return View(model);

        }

        

        /*public void ResetTotalTime()
        {
            totalTime = totalTime.Subtract(totalTime);
        }*/
    }


}
