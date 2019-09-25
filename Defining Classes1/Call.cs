﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
   public class Call
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int DialedNumber { get; set; }
        public int Duration { get; set; }
        public Call(DateTime date,TimeSpan time,int dialedNumber,int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

    }
}
