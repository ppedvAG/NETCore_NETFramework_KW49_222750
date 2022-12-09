using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNet7.Services
{
    public class TimeService : ITimeService
    {
        private string currentTime;


        public TimeService()
        {
            currentTime = DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// Soll die Uhrzeit zurückgeben, wann der Konstruktor von TimeService aufgerufen wird
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetCurrentTime()
        {
            return currentTime;
        }
    }
}
