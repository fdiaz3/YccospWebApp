using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace YccospWebApp.Models
{
    public class TimeStampModel
    {

        public TimeSpan totalTime { get; set; }
        public Stopwatch timer { get; set; }


        public TimeStampModel()
        {
            totalTime = new TimeSpan();
            timer = new Stopwatch();
        }


    }
}