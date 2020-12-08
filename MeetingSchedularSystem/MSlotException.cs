using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
    internal class MSlotException : Exception
    {
        public Personas persona;

        public MSlotException(string message, Personas persona)
            : base(message)
            => this.persona = persona;

    }
}
