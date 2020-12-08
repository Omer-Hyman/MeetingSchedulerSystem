using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
    class DateRangeError: Exception
    {
        public DateRangeError(string message)
            : base (message)
        {

        }
    }
}
