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
using System.Text.RegularExpressions;


namespace MeetingSchedularSystem
{


  public partial class mainUI : Form
  {
    private Meeting meeting;
    private Regex rx;
    private IContainer Scomponents = (IContainer)null;
    private TextBox meetingInitiator;
    private TextBox dateStart;
    private TextBox dateEnd;
        // possibly a better UI way with this
    private TextBox liamResult;
    private TextBox liam_preferenceSet;
    private TextBox liam_exclusionSet;
    private TextBox rosaliaResult;
    private TextBox rosalia_preferenceSet;
    private TextBox rosalia_exclusionSet;
    private TextBox samResult;
    private TextBox sam_exclusionSet;
    private TextBox sam_preferenceSet;
    private TextBox heatherResult;
    private TextBox heather_exclusionSet;
    private TextBox heather_preferenceSet;
    private TextBox meetingStatus;
    private TextBox meetingErrors;
    private TextBox meetingDate;
    private TextBox meetingSlotNo;




    public mainUI()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            /*      this.Hide();
                  Form persona = new PersonaSelect();
                  persona.Show();*/
            string[] array1 = this.dateStart.Text.Split('.');
            string[] array2 = this.dateEnd.Text.Split('.');
            DateTime startDate = new DateTime(int.Parse(array1[2]), int.Parse(array1[1]), int.Parse(array1[0]));
            DateTime endDate = new DateTime(int.Parse(array2[2]), int.Parse(array2[1]), int.Parse(array2[0]));
            // UI components, set values
            try
            {
                this.meeting = new Meeting(new Initiator(this.meetingInitiator.Text.Trim()), startDate, endDate);
                foreach (Personas persona in this.GetPersonas())
                    this.meeting.addPersona(persona);
                try
                {
                    MeetingSlot topSlot = this.meeting.findTopMS();
                    this.meetingErrors.Text = "No Errors";
                    this.meeting.setStatus("Scheduled");
                    this.meetingDate.Text = topSlot.date.ToShortDateString();
                    // slot no
                    int number = (int)MessageBox.Show("Meeting slot has been found: \n" + topSlot.ToString());

                }
                catch (WeakConflictError er)
                {
                    this.meeting.setStatus("Weak Conflict");
                    this.meetingErrors.Text = "Weak conflict: " + er.Message;
                    int num = (int)MessageBox.Show(er.Message, "Weak Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); // change this, UI

                }
                catch (StrongConflictError er)
                {
                    this.meeting.setStatus("Strong Conflict");
                    this.meetingErrors.Text = "Strong Conflict: " + er.Message;
                    int num = (int)MessageBox.Show(er.Message, "Strong Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); // change this, UI

                }
                catch (Exception er)
                {
                    throw er;

                }

            }
            catch (DateRangeError er)
            {
                this.meetingErrors.Text = er.Message;
                int num = (int)MessageBox.Show(er.Message, "Date range error", MessageBoxButtons.OK, MessageBoxIcon.Hand); // change this, UI
                this.meetingStatus.Text = "Error initiating meeting, date";

            }
            // will need an equipment and/or a location version
            catch (Exception er)
            {
                this.meeting.setStatus("Participant error");
                this.meetingErrors.Text = er.Message;
                int num = (int)MessageBox.Show(er.Message, "Participants Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (this.meeting == null || !(this.meetingStatus.Text != "Error initiating meeting"))
                return;
            this.meetingStatus.Text = this.meeting.getStatus();
        }


        private List<Personas> GetPersonas()
        {
            List<Personas> personaList = new List<Personas>();
            // regex would go here if we can't figure out a better way
            // had to do it for one of thoose placement assessment things so be reyt
            bool check = true;
            // persona instance 1: Liam
            Personas persona1 = new Personas("Liam Williams", 5, true);
            this.liamResult.Text = "";
            try
            {
                this.fillPersonaSet(persona1, "preference", this.liam_preferenceSet.Text);

            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox liamResult = this.liamResult;
                liamResult.Text = liamResult.Text + ex.Message + "\n";

            }
            if (this.liamResult.Text == "")
                this.liamResult.Text = "Okay";
            // persona instance 2: Sam
            Personas persona2 = new Personas("Sam Scott", 2, true);
            this.samResult.Text = "";
            try
            {
                this.fillPersonaSet(persona2, "preference", this.sam_preferenceSet.Text);

            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox samResult = this.samResult;
                samResult.Text = samResult.Text + ex.Message + "\n";
            }
            try
            {
                this.fillPersonaSet(persona2, "exclusion", this.sam_exclusionSet.Text);

            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox samResult = this.samResult;
                samResult.Text = samResult.Text + ex.Message + "\n";

            }
            if (this.samResult.Text == "")
            {
                this.samResult.Text = "Okay";
            }
            // Persona 3 instance: Rosalia
            Personas persona3 = new Personas("Rosalia Cortez", 3, true);
            this.rosaliaResult.Text = "";

            try
            {
                this.fillPersonaSet(persona3, "preference", this.rosalia_preferenceSet.Text);

            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox rosaliaResult = this.rosaliaResult;
                rosaliaResult.Text = rosaliaResult.Text + ex.Message + "\n";
            }
            try
            {
                this.fillPersonaSet(persona3, "exclusion", this.rosalia_exclusionSet.Text);
            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox rosaliaResult = this.rosaliaResult;
                rosaliaResult.Text = rosaliaResult.Text + ex.Message + "\n";
            }
            if (this.rosaliaResult.Text == "")
                this.rosaliaResult.Text = "Okay";
            // Persona 4 instance: Heather
            Personas persona4 = new Personas("Heather McLean", 1, true);
            this.heatherResult.Text = "";

            try
            {
                this.fillPersonaSet(persona4, "preference", this.heather_preferenceSet.Text);

            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox rosaliaResult = this.rosaliaResult;
                rosaliaResult.Text = rosaliaResult.Text + ex.Message + "\n";
            }
            try
            {
                this.fillPersonaSet(persona3, "exclusion", this.rosalia_exclusionSet.Text);
            }
            catch (MSlotException ex)
            {
                check = false;
                TextBox heatherResult = this.heatherResult;
                heatherResult.Text = heatherResult.Text + ex.Message + "\n";
            }
            if (this.heatherResult.Text == "")
                this.heatherResult.Text = "Okay";
            personaList.Add(persona1);
            personaList.Add(persona2);
            personaList.Add(persona3);
            personaList.Add(persona4);
            if (!check)
            {
                throw new Exception("Error with participants");

            }
            return personaList;
        }
    private void fillPersonaSet(Personas persona, string setType, string setText)
        {
            foreach(Match match in this.rx.Matches(setText))
            {
                GroupCollection groups = match.Groups;
                // ALSO COMPARE LOCATIONS, EQUIPMENT HERE
                DateTime dateTime = new DateTime(int.Parse(groups[3].Value), int.Parse(groups[2].Value), int.Parse(groups[1].Value));
                if(DateTime.Compare(dateTime, this.meeting.getStartDate()) < 0 )
                    throw new MSlotException(match.ToString() + " (" + (setType == "preference" ? "pref" : "exc") + ") is before the minimum date of the meeting.", persona); // improve, text changes
                if (DateTime.Compare(dateTime, this.meeting.getEndDate()) > 0)
                    throw new MSlotException(match.ToString() + " (" + (setType == "preference" ? "pref" : "exc") + ") is after the maximum date of the meeting.", persona);
                MeetingSlot meetingSlot = new MeetingSlot(dateTime, int.Parse(groups[4].Value));
                if (setType == "preference")
                    persona.addToPSet(meetingSlot);
                else
                    persona.addToESet(meetingSlot);
            }

   
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

    private void historyButton_Click_1(object sender, EventArgs e)
    {

    }
  }
}
