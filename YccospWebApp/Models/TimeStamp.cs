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

        public TimeSpan totalTime { get; private set; }
        private Stopwatch timer;


        public TimeStampModel()
        {
            totalTime = new TimeSpan();
            timer = new Stopwatch();
        }
        
         
        public void TrackTime()
        {
            if (timer.IsRunning)
            {
                throw new InvalidOperationException("Time is already being tracking.");
            }
            else
            {
                timer.Restart();
            }
        }

        public void recordTime()
        {
            
            if (timer.IsRunning)
            {
                timer.Stop();
                totalTime = totalTime.Add(timer.Elapsed);
            }
            else
            {
                throw new InvalidOperationException("Time tracking is currently stopped.");
            }
        }

        public void ResetTotalTime()
        {
            totalTime = totalTime.Subtract(totalTime);
        }
    }
}