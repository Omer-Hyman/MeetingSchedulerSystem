﻿using System;
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
    }

    public string getMeetingDetails()
    {
      return meetingDescription.Text;
    }

    private void submitMeetingButton_Click(object sender, EventArgs e)
    {
      this.Hide();
     
      Meeting newMeeting = new Meeting();
      newMeeting.Title = meetingName.Text;//meeting title
      newMeeting.Description = meetingDescription.Text;//description

      for (int i = 0; i < equipmentList.CheckedItems.Count; i++)
      {
        newMeeting.Equipment[i] = equipmentList.CheckedItems[i].ToString();//equipment
      }

      //newMeeting.Date = datePicker.Value; //date

      /*for (int i = 0; i < guestList.CheckedItems.Count; i++)
      {
        newMeeting.Guests[i] = guestList.CheckedItems[i].ToString();//guests
      }
*/

      //importance level - attached to personas
      //location

    }

    private void guestList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void RequestMeeting_Load(object sender, EventArgs e)
    {

    }

    
  }
}
