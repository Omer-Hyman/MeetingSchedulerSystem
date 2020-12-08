using System;

namespace MeetingSchedularSystem
{
  internal class StrongConflictError : Exception
  {
    public StrongConflictError(string message)
        : base(message)
    {

    }
  }
}
