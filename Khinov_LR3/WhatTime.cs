using System.Globalization;

namespace Khinov_LR3
{
    public class WhatTime
    {
        DateTime hourNow;
        public WhatTime()
        {
            hourNow = DateTime.Now;
        }

        public string GetTimeNow()
        {
            int hour = hourNow.Hour;
            if (hour >= 0 && hour < 6) { return "Night time!"; }
            if (hour >= 6 && hour < 12) { return "Morning time!"; }
            if (hour >= 12 && hour < 18) { return "Day time!"; }
            if (hour >= 18 && hour < 24) { return "Afternoon time!"; }
            return "Error!";
        }
    }
}
