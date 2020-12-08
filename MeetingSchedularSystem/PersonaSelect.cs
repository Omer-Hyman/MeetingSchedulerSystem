using System;
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

    private void personaList_SelectedIndexChanged(object sender, EventArgs e)
    {
      Form main = new mainPage(personaList.SelectedItem.ToString());
      this.Hide();
      main.Show();
      switch (this.Text)
      {
        case "Liam Williams":

          // persona instance 1: Liam
          Personas persona1 = new Personas("Liam Williams", 5, true);
          /*try
          {
            this.fillPersonaSet(persona1, "preference", this.liam_preferenceSet.Text);
          }
          catch (MSlotException ex)
          {
            check = false;
            TextBox liamResult = this.liamResult;
            liamResult.Text = liamResult.Text + ex.Message + "\n";
          }*/
          break;
        case "Sam Scott":

          break;
        case "Rosalia Cortez":

          break;
        case "Heather McLean":

          break;
      }


    }

    private void userSelectLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
