using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetingSchedularSystem
{
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

  internal class Meeting
  {
    // basic attributes
    private Initiator initiator;
    private DateTime startDate;
    private DateTime endDate;
    private HashSet<Personas> personas;

    // additionals, some to be added later
    private string[] equipment = new string[5];
    private string description;
    private string location;
    private UserType importanceLevel;
    private string status = "Request";

    public Meeting(Initiator initiator, DateTime date, DateTime startDate, DateTime endDate, string[] equipment, string description, string location)
    {
      // constructor
      this.initiator = initiator;
      this.startDate = DateTime.Compare(startDate, endDate) >= 0 ? startDate : throw new DateRangeError("The end date cannot be before the start date");
      this.endDate = endDate;
      this.equipment = equipment;
      this.personas = new HashSet<Personas>();
      this.description = description;
      this.location = location;
      //location
    }
    public Meeting()
    {
      DateTime timeDate = new DateTime(2020, 3, 1, 7, 0, 0);
      description = "";
      importanceLevel = UserType.Five;
    }

    public Meeting(Initiator initiator, DateTime startDate, DateTime endDate)
    {
      this.initiator = initiator;
      this.startDate = startDate;
      this.endDate = endDate;
    }

    public void setStatus(string status) => this.status = status;
    public string getStatus() => this.status;

    public void addPersona(Personas persona) => this.personas.Add(persona);
    public List<MeetingSlot> GetAvailableMS() => new List<MeetingSlot>();
    public DateTime getStartDate() => this.startDate;
    public DateTime getEndDate() => this.endDate;


    public MeetingSlot findTopMS()
    {
      DateTime firstTime = this.startDate;
      int number_of_slot = 1;
      // generic logic, we'll implement our own, better version
      HashSet<MeetingSlot> first = new HashSet<MeetingSlot>();
      HashSet<MeetingSlot> source = new HashSet<MeetingSlot>();
      HashSet<MeetingSlot> MS_Set = new HashSet<MeetingSlot>();
      for (; DateTime.Compare(firstTime, this.endDate) <= 0; firstTime = firstTime.AddDays(1.0))
      {// can also change number of slots
        for (; number_of_slot <= 4; ++number_of_slot)
        {
          MeetingSlot meeting_slot = new MeetingSlot(firstTime.Year, firstTime.Month, firstTime.Day, number_of_slot);
          first.Add(meeting_slot);
          int number = 0;
          foreach (Personas persona in this.personas)
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
          if (this.personas.Count == number)
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
        throw new WeakConflictError("No available meeting slot in ALL preference sets, " + (object)meetingSlots.Count<MeetingSlot>() + " but the slots are NOT in the exclusion sets in range.", meetingSlots);
      throw new StrongConflictError("No available meeting slots found in preference slots, and no available meeting slots found that are not in exclusion sets");


    }
    
    public String[] Equipment
    {
      get
      {
        return equipment;
      }
      set
      {
        equipment = value;
      }
    }
    public string Description
    {
      get
      {
        return description;
      }
      set
      {
        description = value;
      }
    }
    public string Title { get; set; }
    public UserType Importance
    {
      get
      {
        return importanceLevel;
      }
      set
      {
        importanceLevel = value;
      }
    }

  }

}