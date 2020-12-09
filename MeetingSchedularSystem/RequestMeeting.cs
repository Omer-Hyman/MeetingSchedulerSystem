﻿using System;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  public partial class RequestMeeting : Form
  {
    public RequestMeeting(string initiator)
    {
      InitializeComponent();
      initiatorLabel.Text = initiator + ", Please input meeting details.";
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

    public void setMeetingDetails(string name, DateTime date, string location, string[] equipment, string[] guests, string description)
    {
      
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

      for (int i = 0; i < guestList.CheckedItems.Count; i++)
      {
        newMeeting.Guests[i] = guestList.CheckedItems[i].ToString();//guests
      }

      for (int i = 0; i < locationList.CheckedItems.Count; i++)
      {
        newMeeting.Location[i] = locationList.CheckedItems[i].ToString();//guests
      }

      newMeeting.sDate = startDate.Value;//date
      newMeeting.eDate = endDate.Value;//date

    }

    private void guestList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void RequestMeeting_Load(object sender, EventArgs e)
    {

    }

    
  }
}
