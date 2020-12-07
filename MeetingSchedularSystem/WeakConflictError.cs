using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
    internal class WeakConflictError: Exception
    {
        public IEnumerable<MeetingSlot> notInExclusionSets;
        public WeakConflictError(string message, IEnumerable<MeetingSlot> notInExclusionSets)
            : base(message)
            => this.notInExclusionSets = notInExclusionSets;
    }
}
