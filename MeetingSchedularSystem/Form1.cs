using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace MeetingSchedularSystem
{


  public partial class mainUI : Form
  {
    public mainUI()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form requestMeeting = new RequestMeeting();
      requestMeeting.Show();
    }

    private void historyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form meetingHistory = new MeetingHistory();
            meetingHistory.Show();
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pendingMeetingItem_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void mainUI_Load(object sender, EventArgs e)
    {

        }
    private void scheduledMeetingPlaceholder_Click(object sender, EventArgs e)
     {


     }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ScheduledMeetings scheduled = new ScheduledMeetings();
            scheduled.Show();

        }
    }
}
