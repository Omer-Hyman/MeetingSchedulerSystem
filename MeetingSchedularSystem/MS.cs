namespace MeetingSchedularSystem
{
  using System;
  internal class MeetingSlot
  {
    public DateTime date;
    public int ID;
    public string location;

    public MeetingSlot(int year, int month, int day, int ID, string location)
    {
      this.date = new DateTime(year, month, day);
      this.ID = ID;
      this.location = location;
    }

    public MeetingSlot(DateTime date, int ID, string location)
    {
      this.date = date;
      this.ID = ID;
      this.location = location;
    }

        public override string ToString() => this.date.ToShortDateString() + " Slot " + (object)this.ID + " ," + (object)this.location;

    public override bool Equals(object obj) => this.ToString().Equals(obj.ToString());

    public override int GetHashCode() => this.ToString().GetHashCode();
  }


}
