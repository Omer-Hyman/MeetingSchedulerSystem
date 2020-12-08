using System;

namespace MeetingSchedularSystem
{
  class DateRangeError : Exception
  {
    public DateRangeError(string message)
        : base(message)
    {

    }
  }
}
