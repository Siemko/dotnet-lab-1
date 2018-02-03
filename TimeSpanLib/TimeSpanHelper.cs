using System;

namespace TimeSpanLib
{
    public class TimeSpanHelper
    {
        public double CalculateTimeSpan(DateTime StartDate, DateTime EndDate)
        {
            return (EndDate - StartDate).TotalMilliseconds;
        }
    }
}