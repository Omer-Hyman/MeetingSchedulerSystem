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
  public partial class RequestMeeting : Form
  {
    public RequestMeeting()
    {
      InitializeComponent();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void newMeetingLabel_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void cancelMeetingButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form mainUI = new mainUI();
      mainUI.Show();

    }

    private void submitMeetingButton_Click(object sender, EventArgs e)
    {
      //create a new instance of meeting with the values from this form going into its variables
      //int i = 0;
      Meeting newMeeting = new Meeting();

      //newMeeting name = meetingName.Text;

      newMeeting.Date = datePicker.Value.ToString();
      newMeeting.Time = timePicker.Value.ToString();

      foreach(object itemChecked in guestList.CheckedItems)
      {
        newMeeting.Guests = itemChecked.ToString();//should really be guests[i] bc guests is an array but no errors like this for some reason
      }

      //missed a couple

      newMeeting.MeetingDescription = meetingDescription.Text;
        
    }

    private void guestList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
