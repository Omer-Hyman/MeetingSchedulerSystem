using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetingSchedularSystem
{
  internal class Meeting
  {
    // basic attributes that every meeting needs.
    private Initiator initiator;
    private DateTime startDate;
    private DateTime endDate;
    private HashSet<Personas> personaCollection;
    private string equipment;
    private string location;
    private string status = "Request";

        // the constructor for a Meeting
    public Meeting(Initiator initiator, DateTime startDate, DateTime endDate, string location, string equipment) //string location)
    {
      this.startDate = DateTime.Compare(endDate, startDate) >= 0 ? startDate : throw new DateRangeError("End date cannot be before start date when arranging a meeting.");
      this.initiator = initiator;
      this.endDate = endDate;
      this.personaCollection = new HashSet<Personas>();
      this.location = location;
      this.equipment = equipment;
   }

    public void setStatus(string status) => this.status = status;
    public string getStatus() => this.status;
    public void addPersona(Personas persona) => this.personaCollection.Add(persona);
    public List<MeetingSlot> GetAvailableMS() => new List<MeetingSlot>();
    public DateTime getStartDate() => this.startDate;
    public DateTime getEndDate() => this.endDate;

    public string getLocation() => this.location;
    public string getEquipment() => this.equipment;
    public MeetingSlot findTopMS()
    {
      DateTime firstTime = this.startDate;
      string location = this.location;
      int number_of_slot = 1;
      // generic logic, we'll implement our own, better version
      HashSet<MeetingSlot> first = new HashSet<MeetingSlot>();
      HashSet<MeetingSlot> source = new HashSet<MeetingSlot>();
      HashSet<MeetingSlot> MS_Set = new HashSet<MeetingSlot>();
      for (; DateTime.Compare(firstTime, this.endDate) <= 0; firstTime = firstTime.AddDays(1.0))
      {// can also change number of slots
        for (; number_of_slot <= 4; ++number_of_slot)
        {
               
          MeetingSlot meeting_slot = new MeetingSlot(firstTime.Year, firstTime.Month, firstTime.Day, number_of_slot, location);
          first.Add(meeting_slot);
          int number = 0;
          foreach (Personas persona in this.personaCollection)
          {
            bool check_1 = persona.MSInESet(meeting_slot);
            bool check_2 = persona.MSInPSet(meeting_slot);
            if (check_1 == true)
            {
              MS_Set.Add(meeting_slot);
            }
            else if (check_2)
              ++number;
          }
          if (this.personaCollection.Count == number)
            source.Add(meeting_slot);
        }
        number_of_slot = 1;
      }
      if (source.Count > 0)
      {
        return source.ElementAt<MeetingSlot>(0);
      }
      IEnumerable<MeetingSlot> meetingSlots = first.Except<MeetingSlot>((IEnumerable<MeetingSlot>)MS_Set);
      // conflict resolution errors
      if (meetingSlots.Count<MeetingSlot>() > 0)
        throw new WeakConflictError("No available meeting slot in ALL preference sets, but" + (object)meetingSlots.Count<MeetingSlot>() + " slots not within range", meetingSlots);
      throw new StrongConflictError("No available meeting slots found in preference slots, and no available meeting slots found that are not in exclusion sets");


    }
    

  }

}

//Omer's class

/*  class Meeting
  {
    public string MeetingInitiator { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string[] Guests { get; set; }
    public string[] Equipment { get; set; }
    public string MeetingDescription { get; set; }

    private string meetingIniator;
    private string date;
    private string time;
    private string[] guests;
    private string[] equipment;
    private string meetingDescrption;

  }*/