using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
  internal class Personas
  {
    public string name;
    private int importanceLevel;
    public bool initiator;
    public HashSet<MeetingSlot> preferenceSet;
    public HashSet<MeetingSlot> exclusionSet;

    // preference and exclusion sets could go here, probably as hashsets. the idea would be for a class to handle meeting 'instances'
    // so hashset of type 'MeetingInstance'


    public Personas(string Name, int Importance, bool initiator)
    {
      name = Name;
      importanceLevel = Importance;
      this.initiator = initiator;
      this.preferenceSet = new HashSet<MeetingSlot>();
      this.exclusionSet = new HashSet<MeetingSlot>();

            // would pass each individual's preference, exclusions here

    }
    
    public void addToPSet(MeetingSlot meetingS)
    {
            if(this.exclusionSet.Contains(meetingS))
                throw new MSlotException("Slot is in the exclusion set." + (object) meetingS, this);
            this.preferenceSet.Add(meetingS);
    }

    public void addToESet(MeetingSlot meetingS)
    {
            if(this.preferenceSet.Contains(meetingS))
                throw new MSlotException("Slot already in pref set" + (object) meetingS, this);
            this.preferenceSet.Add(meetingS);
    }

    public bool MSInPSet(MeetingSlot meetingS) => this.preferenceSet.Contains(meetingS);
    public bool MSInESet(MeetingSlot meetingS) => this.exclusionSet.Contains(meetingS);
    //public Personas()
    //{
   //  name = "Fname Lname";
   //   importanceLevel = 5;
   //   initiator = false;

   // }

    //public string Name { get; set; }
    //public int Importance { get; set; }
    //public bool Initiator { get; set; }
  }
}
