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
  public partial class mainPage : Form
  {
    public mainPage(string initiator)
    {
      InitializeComponent();
      
      helloUser.Text += initiator;//meeting initiator
      switchUser.Text = "Not " + initiator + "? Switch User";

    }

    private void mainPage_Load(object sender, EventArgs e)
    {
      
    }

    private void newMeeting_Click(object sender, EventArgs e)
    {
      Form newMeeting = new RequestMeeting();
      newMeeting.Show();
    }


    private void viewSets_Click(object sender, EventArgs e)
    {
      Form viewSets = new PESets();
      viewSets.Show();
    }

    private void meetingHistory_Click(object sender, EventArgs e)
    {
      /*Form history = new meetingHistory(); // can't find MeetingHistory for some reason - maybe bc it's a partail class?
      history.Show();*/
    }

    private void helloUser_Click(object sender, EventArgs e)
    {

    }

    private void switchUser_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form switchUser = new PersonaSelect();
      switchUser.Show();
    }

    private void tempMeetingLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
