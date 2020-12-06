using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
  class Meeting
  {

    public string MeetingInitiator{ get; set; }
    public string Date{ get; set; }
    public string Time{ get; set; }
    public string Guests{ get; set; }
    public string Equipment { get; set; }
    public string MeetingDescription { get; set; }
  
    private string meetingIniator;
    private string date;
    private string time;
    private string[] guests;
    private string[] equipment;
    private string meetingDescrption;

  }
}
