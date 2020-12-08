namespace MeetingSchedularSystem
{
  using System;
  internal class MeetingSlot
  {
    public DateTime date;
    public int ID;

    public MeetingSlot(int year, int month, int day, int ID)
    {
      this.date = new DateTime(year, month, day);
      this.ID = ID;
    }

    public MeetingSlot(DateTime date, int ID)
    {
      this.date = date;
      this.ID = ID;
    }

    public override string ToString() => this.date.ToShortDateString() + " Slot " + (object)this.ID;

    public override bool Equals(object obj) => this.ToString().Equals(obj.ToString());

    public override int GetHashCode() => this.ToString().GetHashCode();
  }


}
