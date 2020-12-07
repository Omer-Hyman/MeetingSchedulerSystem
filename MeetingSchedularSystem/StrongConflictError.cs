using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
    internal class StrongConflictError: Exception
    {
        public StrongConflictError(string message)
            : base(message)
        {

        }
    }
}
