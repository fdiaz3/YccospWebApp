using Microsoft.VisualStudio.TestTools.UnitTesting;
using YccospWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace YccospWebApp.Models.Tests
{
    
    [TestClass()]
    public class TimeStampModelTests
    {
        TimeStampModel timeClock = new TimeStampModel();
        TimeSpan emptyTimeSpan = new TimeSpan(0, 0, 0);


        [TestMethod()]
        public void TimeStampModelTest()
        {
            Assert.IsNotNull(timeClock);
            Assert.IsTrue(timeClock.totalTime.Equals(emptyTimeSpan));
            
        }

        [TestMethod()]
        public void TrackTimeTest()
        {
            timeClock.TrackTime();
            System.Threading.Thread.Sleep(3600);
            timeClock.recordTime();
            Assert.AreNotEqual(emptyTimeSpan, timeClock.totalTime);
            Assert.AreEqual(3600, timeClock.totalTime.TotalMilliseconds, 1.5);
            timeClock.ResetTotalTime();
            Assert.AreEqual(emptyTimeSpan, timeClock.totalTime);
        }
    }
}