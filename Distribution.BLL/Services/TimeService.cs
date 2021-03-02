using Distribution.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.BLL.Services
{
    public class TimeService : ITimeService
    {
        public string GetTimeForTomorrow()
        {
            return DateTime.Now.AddDays(1).ToShortDateString();
        }
    }
}
