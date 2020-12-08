using System;
using System.Collections.Generic;

namespace MeetingSchedularSystem
{
  internal class WeakConflictError : Exception
  {
    public IEnumerable<MeetingSlot> notInExclusionSets;
    public WeakConflictError(string message, IEnumerable<MeetingSlot> notInExclusionSets)
        : base(message)
        => this.notInExclusionSets = notInExclusionSets;
  }
}
