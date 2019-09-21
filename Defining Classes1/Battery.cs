using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    public class Battery
    {
        public int HoursIdle { get { return _hoursIdle; } set { _hoursIdle = value; } }
        public int HoursTalk { get { return _hourseTalk; } set { _hourseTalk = value; } }
        public BatteryType Model { get { return _model; } set { _model = value; } }
        private int _hoursIdle;
        private int _hourseTalk;
        private BatteryType _model;
        public Battery(int hoursIdle, int hoursTalk, BatteryType model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Model = model;
        }
    }
}
