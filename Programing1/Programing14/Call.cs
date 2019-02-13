using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
    public class Call
    {
        public DateTime Date { get; set; }
        public int StartTime { get; set; }
        public int Duration { get; set; }

        public Call(DateTime date, int startTime, int duration)
        {
            this.Date = date;
            this.StartTime = startTime;
            this.Duration = duration;
        }
        public Call()
        {

        }
    }
}
