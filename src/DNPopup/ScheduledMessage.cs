using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNPopup
{
    internal class ScheduledMessage
    {
        public string Message
        {
            get;
            private set;
        }

        public DateTimeOffset ReservationTime
        {
            get;
            private set;
        }

        public ScheduledMessage(string message, DateTimeOffset reservationTime)
        {
            this.Message = message;
            this.ReservationTime = reservationTime;
        }
    }
}
