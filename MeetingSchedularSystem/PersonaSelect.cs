using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  public partial class PersonaSelect : Form
  {
    public PersonaSelect()
    {
      InitializeComponent();

      Personas mehmet = new Personas("Mehmet Ozcan", 2, false);
      Personas heather = new Personas("Heather McLean", 3, false);
      Personas liam = new Personas("Liam Williams", 1, false);
      Personas sam = new Personas("Sam Scott", 5, false);
      Personas rosalia = new Personas("Rosalia Cortez", 4, false);
    }
    public string initiator()
    {
      return this.Text;
    }
    private void user5_Click(object sender, EventArgs e)
    {
      this.Hide();
      initiator();
      Form meetingRequest = new RequestMeeting();
      meetingRequest.Show();
    }

    private void user1_Click(object sender, EventArgs e)
    {
      this.Hide();
      
      Form meetingRequest = new RequestMeeting();
      meetingRequest.Show();

    }

    private void user3_Click(object sender, EventArgs e)
    {
      this.Hide();
      //newMeeting.initiator = "Heather McLean";
      Form meetingRequest = new RequestMeeting();
      meetingRequest.Show();
    }

    private void user4_Click(object sender, EventArgs e)
    {
      this.Hide();
      //newMeeting.initiator = "Liam Williams";
      Form meetingRequest = new RequestMeeting();
      meetingRequest.Show();
    }

    private void user2_Click(object sender, EventArgs e)
    {
      this.Hide();
      //newMeeting.initiator = "Sam Scott";
      Form meetingRequest = new RequestMeeting();
      meetingRequest.Show();
    }
  }
}
