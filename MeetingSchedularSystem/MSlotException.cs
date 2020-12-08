using System;

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
