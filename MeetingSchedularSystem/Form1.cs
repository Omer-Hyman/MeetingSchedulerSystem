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


  public class SchedulerUI : Form
  {
    private Meeting meeting;
    private Regex rx;
    private Button button1;
    private IContainer components = (IContainer)null;
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
    private GroupBox meetingDetails;
    private Label label26;
        private Label label25;
        private Label label23;
        private Label label22;
        private Label label24;
        private Label label20;


        private Label meetingSlot;




        //public mainUI()
        //{
        //  InitializeComponent();
        //}
        public SchedulerUI() => this.InitializeComponent();
        private void button1_Click(object sender, EventArgs e)
        {
            /*      this.Hide();
                  Form persona = new PersonaSelect();
                  persona.Show();*/
            string[] array1 = this.dateStart.Text.Split('/');
            string[] array2 = this.dateEnd.Text.Split('/');
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
            this.rx = new Regex("(\\d{1,2})/(\\d{1,2})/(\\d{4}) Slot (\\d)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

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
    private void InitializeComponent()
        {
            this.button1 = new Button();
            this.meetingInitiator = new TextBox();

            this.dateStart = new TextBox();
        
            this.dateEnd = new TextBox();
            this.liam_preferenceSet = new TextBox();

            this.liam_exclusionSet = new TextBox();
           
            this.sam_exclusionSet = new TextBox();
           
            this.sam_preferenceSet = new TextBox();
           
            this.rosalia_exclusionSet = new TextBox();
           
            this.rosalia_preferenceSet = new TextBox();
          
            this.heather_exclusionSet = new TextBox();

            this.heather_preferenceSet = new TextBox();
            // add all the labels
            
            this.meetingDetails = new GroupBox();
           
            this.meetingErrors = new TextBox();
            this.meetingSlot = new Label();
            this.meetingSlotNo = new TextBox();
            this.meetingDate = new TextBox();
            this.meetingStatus = new TextBox();
            this.liamResult = new TextBox();
    
            this.samResult = new TextBox();

            this.heatherResult = new TextBox();
            // UI changes needed here
            this.rosaliaResult = new TextBox();
            this.meetingDetails.SuspendLayout();
            this.SuspendLayout();
            this.button1.Location = new Point(12, 146);
            this.button1.Name = "setupMeeting";
            this.button1.Size = new Size(151, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Setup Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.meetingInitiator.Location = new Point(12, 30);
            this.meetingInitiator.Name = "meetingInitiator";
            this.meetingInitiator.Size = new Size(151, 20);
            this.meetingInitiator.TabIndex = 1;
            this.meetingInitiator.Text = "Liam";
            //this.label1.AutoSize = true;
            //this.label1.Location = new Point(12, 9);
            //this.label1.Name = "label1";
            //this.label1.Size = new Size(82, 13);
            //this.label1.TabIndex = 2;
            //this.label1.Text = "Meeting Initiator";
            this.dateStart.Location = new Point(12, 72);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new Size(151, 20);
            this.dateStart.TabIndex = 3;
            this.dateStart.Text = "10/12/2018";
            //this.label2.AutoSize = true;
            //this.label2.Location = new Point(12, 53);
            //this.label2.Name = "label2";
            //this.label2.Size = new Size(137, 13);
            //this.label2.TabIndex = 4;
            //this.label2.Text = "Date From (DD/MM/YYYY)";
            //this.label3.AutoSize = true;
            //this.label3.Location = new Point(12, 95);
            //this.label3.Name = "label3";
            //this.label3.Size = new Size((int)sbyte.MaxValue, 13);
            //this.label3.TabIndex = 6;
            //this.label3.Text = "Date To (DD/MM/YYYY)";
            this.dateEnd.Location = new Point(12, 114);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new Size(151, 20);
            this.dateEnd.TabIndex = 5;
            this.dateEnd.Text = "12/12/2018";
            //this.label4.AutoSize = true;
            //this.label4.Location = new Point(173, 10);
            //this.label4.Name = "label4";
            //this.label4.Size = new Size(44, 13);
            //this.label4.TabIndex = 7;
            //this.label4.Text = "liam";
            this.liam_preferenceSet.Location = new Point(176, 48);
            this.liam_preferenceSet.Multiline = true;
            this.liam_preferenceSet.Name = "liam_preferenceSet";
            this.liam_preferenceSet.Size = new Size(200, 60);
            this.liam_preferenceSet.TabIndex = 8;
            this.liam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
       /*     this.label5.AutoSize = true;
            this.label5.Location = new Point(173, 31);
            this.label5.Name = "label5";
            this.label5.Size = new Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preference Set";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(173, 111);
            this.label6.Name = "label6";
            this.label6.Size = new Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Exclusion Set";*/
            this.liam_exclusionSet.Location = new Point(176, 128);
            this.liam_exclusionSet.Multiline = true;
            this.liam_exclusionSet.Name = "liam_exclusionSet";
            this.liam_exclusionSet.Size = new Size(200, 60);
            this.liam_exclusionSet.TabIndex = 10;
            this.liam_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
            //this.label7.AutoSize = true;
            //this.label7.Location = new Point(378, 111);
            //this.label7.Name = "label7";
            //this.label7.Size = new Size(71, 13);
            //this.label7.TabIndex = 16;
            //this.label7.Text = "Exclusion Set";
            this.sam_exclusionSet.Location = new Point(381, 128);
            this.sam_exclusionSet.Multiline = true;
            this.sam_exclusionSet.Name = "sam_exclusionSet";
            this.sam_exclusionSet.Size = new Size(200, 60);
            this.sam_exclusionSet.TabIndex = 15;
            this.sam_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
/*            this.label8.AutoSize = true;
            this.label8.Location = new Point(378, 31);
            this.label8.Name = "label8";
            this.label8.Size = new Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preference Set";*/
            this.sam_preferenceSet.Location = new Point(381, 48);
            this.sam_preferenceSet.Multiline = true;
            this.sam_preferenceSet.Name = "sam_preferenceSet";
            this.sam_preferenceSet.Size = new Size(200, 60);
            this.sam_preferenceSet.TabIndex = 13;
            this.sam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
 /*           this.label9.AutoSize = true;
            this.label9.Location = new Point(378, 10);
            this.label9.Name = "label9";
            this.label9.Size = new Size(24, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "sam";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(587, 111);
            this.label10.Name = "label10";
            this.label10.Size = new Size(71, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Exclusion Set";*/
            this.rosalia_exclusionSet.Location = new Point(587, 128);
            this.rosalia_exclusionSet.Multiline = true;
            this.rosalia_exclusionSet.Name = "rosalia_exclusionSet";
            this.rosalia_exclusionSet.Size = new Size(200, 60);
            this.rosalia_exclusionSet.TabIndex = 20;
            this.rosalia_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
            //this.label11.AutoSize = true;
            //this.label11.Location = new Point(587, 31);
            //this.label11.Name = "label11";
            //this.label11.Size = new Size(78, 13);
            //this.label11.TabIndex = 19;
            //this.label11.Text = "Preference Set";
            this.rosalia_preferenceSet.Location = new Point(587, 48);
            this.rosalia_preferenceSet.Multiline = true;
            this.rosalia_preferenceSet.Name = "rosalia_preferenceSet";
            this.rosalia_preferenceSet.Size = new Size(200, 60);
            this.rosalia_preferenceSet.TabIndex = 18;
            this.rosalia_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
/*            this.label12.AutoSize = true;
            this.label12.Location = new Point(584, 10);
            this.label12.Name = "label12";
            this.label12.Size = new Size(26, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "rosalia";
            this.label13.AutoSize = true;
            this.label13.Location = new Point(794, 111);
            this.label13.Name = "label13";
            this.label13.Size = new Size(71, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Exclusion Set";*/
            this.heather_exclusionSet.Location = new Point(794, 128);
            this.heather_exclusionSet.Multiline = true;
            this.heather_exclusionSet.Name = "heather_exclusionSet";
            this.heather_exclusionSet.Size = new Size(200, 60);
            this.heather_exclusionSet.TabIndex = 25;
            this.heather_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
            //this.label14.AutoSize = true;
            //this.label14.Location = new Point(794, 31);
            //this.label14.Name = "label14";
            //this.label14.Size = new Size(78, 13);
            //this.label14.TabIndex = 24;
            //this.label14.Text = "Preference Set";
            this.heather_preferenceSet.Location = new Point(794, 48);
            this.heather_preferenceSet.Multiline = true;
            this.heather_preferenceSet.Name = "heather_preferenceSet";
            this.heather_preferenceSet.Size = new Size(200, 60);
            this.heather_preferenceSet.TabIndex = 23;
            this.heather_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
/*            this.label15.AutoSize = true;
            this.label15.Location = new Point(791, 10);
            this.label15.Name = "label15";
            this.label15.Size = new Size(50, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "heather";
            this.label16.AutoSize = true;
            this.label16.Location = new Point(1000, 111);
            this.label16.Name = "label16";
            this.label16.Size = new Size(71, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Exclusion Set";
     
            this.label17.AutoSize = true;
            this.label17.Location = new Point(1000, 31);
            this.label17.Name = "label17";
            this.label17.Size = new Size(78, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Preference Set";
      
            this.label18.AutoSize = true;
            this.label18.Location = new Point(997, 10);
            this.label18.Name = "label18";
            this.label18.Size = new Size(30, 13);
            this.label18.TabIndex = 27;
       */
            this.meetingDetails.Controls.Add((Control)this.label26);
            this.meetingDetails.Controls.Add((Control)this.meetingErrors);
            this.meetingDetails.Controls.Add((Control)this.meetingSlot);
            this.meetingDetails.Controls.Add((Control)this.meetingSlotNo);
            this.meetingDetails.Controls.Add((Control)this.label25);
            this.meetingDetails.Controls.Add((Control)this.meetingDate);
            this.meetingDetails.Controls.Add((Control)this.label24);
            this.meetingDetails.Controls.Add((Control)this.meetingStatus);
            this.meetingDetails.Location = new Point(279, 271);
            this.meetingDetails.Name = "meetingDetails";
            this.meetingDetails.Size = new Size(586, 111);
            this.meetingDetails.TabIndex = 32;
            this.meetingDetails.TabStop = false;
            this.meetingDetails.Text = "Meeting Details";
            //this.label26.AutoSize = true;
            //this.label26.Location = new Point(6, 64);
            //this.label26.Name = "label26";
            //this.label26.Size = new Size(34, 13);
            //this.label26.TabIndex = 55;
            //this.label26.Text = "Errors";
            this.meetingErrors.Location = new Point(9, 80);
            this.meetingErrors.Name = "meetingErrors";
            this.meetingErrors.ReadOnly = true;
            this.meetingErrors.Size = new Size(558, 20);
            this.meetingErrors.TabIndex = 54;
            this.meetingErrors.Text = "No Errors";
            this.meetingSlot.AutoSize = true;
            this.meetingSlot.Location = new Point(390, 16);
            this.meetingSlot.Name = "meetingSlot";
            this.meetingSlot.Size = new Size(66, 13);
            this.meetingSlot.TabIndex = 53;
            this.meetingSlot.Text = "Meeting Slot";
            this.meetingSlotNo.Location = new Point(393, 32);
            this.meetingSlotNo.Name = "meetingSlotNo";
            this.meetingSlotNo.ReadOnly = true;
            this.meetingSlotNo.Size = new Size(174, 20);
            this.meetingSlotNo.TabIndex = 52;
            this.meetingSlotNo.Text = "Not Planned";
/*            this.label25.AutoSize = true;
            this.label25.Location = new Point(200, 16);
            this.label25.Name = "label25";
            this.label25.Size = new Size(71, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "Meeting Date";*/
            this.meetingDate.Location = new Point(203, 32);
            this.meetingDate.Name = "meetingDate";
            this.meetingDate.ReadOnly = true;
            this.meetingDate.Size = new Size(174, 20);
            this.meetingDate.TabIndex = 50;
            this.meetingDate.Text = "Not Planned";
     /*       this.label24.AutoSize = true;
            this.label24.Location = new Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new Size(37, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Status";*/
            this.meetingStatus.Location = new Point(9, 32);
            this.meetingStatus.Name = "meetingStatus";
            this.meetingStatus.ReadOnly = true;
            this.meetingStatus.Size = new Size(174, 20);
            this.meetingStatus.TabIndex = 48;
            this.meetingStatus.Text = "Not Planned";
            //this.label19.AutoSize = true;
            //this.label19.Location = new Point(173, 191);
            //this.label19.Name = "label19";
            //this.label19.Size = new Size(37, 13);
            //this.label19.TabIndex = 39;
            //this.label19.Text = "Result";
            this.liamResult.Location = new Point(176, 207);
            this.liamResult.Multiline = true;
            this.liamResult.Name = "liamResult";
            this.liamResult.ReadOnly = true;
            this.liamResult.Size = new Size(200, 40);
            this.liamResult.TabIndex = 38;
            this.liamResult.Text = "N/A";
            //this.label20.AutoSize = true;
            //this.label20.Location = new Point(378, 191);
            //this.label20.Name = "label20";
            //this.label20.Size = new Size(37, 13);
            //this.label20.TabIndex = 41;
            //this.label20.Text = "Result";
            this.samResult.Location = new Point(381, 207);
            this.samResult.Multiline = true;
            this.samResult.Name = "samResult";
            this.samResult.ReadOnly = true;
            this.samResult.Size = new Size(200, 40);
            this.samResult.TabIndex = 40;
            this.samResult.Text = "N/A";
            //this.label21.AutoSize = true;
            //this.label21.Location = new Point(791, 191);
            //this.label21.Name = "label21";
            //this.label21.Size = new Size(37, 13);
            //this.label21.TabIndex = 45;
            //this.label21.Text = "Result";
            this.heatherResult.Location = new Point(794, 207);
            this.heatherResult.Multiline = true;
            this.heatherResult.Name = "heatherResult";
            this.heatherResult.ReadOnly = true;
            this.heatherResult.Size = new Size(200, 40);
            this.heatherResult.TabIndex = 44;
            this.heatherResult.Text = "N/A";
            //this.label22.AutoSize = true;
            //this.label22.Location = new Point(584, 191);
            //this.label22.Name = "label22";
            //this.label22.Size = new Size(37, 13);
            //this.label22.TabIndex = 43;
            //this.label22.Text = "Result";
            this.rosaliaResult.Location = new Point(587, 207);
            this.rosaliaResult.Multiline = true;
            this.rosaliaResult.Name = "rosaliaResult";
            this.rosaliaResult.ReadOnly = true;
            this.rosaliaResult.Size = new Size(200, 40);
            this.rosaliaResult.TabIndex = 42;
            this.rosaliaResult.Text = "N/A";
            //this.label23.AutoSize = true;
            //this.label23.Location = new Point(997, 191);
            //this.label23.Name = "label23";
            //this.label23.Size = new Size(37, 13);
            //this.label23.TabIndex = 47;
            //this.label23.Text = "Result";
  
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1080, 720);
            //this.Controls.Add((Control)this.label23);
       
            //this.Controls.Add((Control)this.label21);
            this.Controls.Add((Control)this.heatherResult);
            this.Controls.Add((Control)this.label22);
            this.Controls.Add((Control)this.rosaliaResult);
            this.Controls.Add((Control)this.label20);
            this.Controls.Add((Control)this.samResult);
/*            this.Controls.Add((Control)this.label19);*/
            this.Controls.Add((Control)this.liamResult);
            this.Controls.Add((Control)this.meetingDetails);
            //this.Controls.Add((Control)this.label16);
            //this.Controls.Add((Control)this.label17);
            //this.Controls.Add((Control)this.label18);
            //this.Controls.Add((Control)this.label13);
            this.Controls.Add((Control)this.heather_exclusionSet);
            //this.Controls.Add((Control)this.label14);
            this.Controls.Add((Control)this.heather_preferenceSet);
            //this.Controls.Add((Control)this.label15);
            //this.Controls.Add((Control)this.label10);
            this.Controls.Add((Control)this.rosalia_exclusionSet);
            //this.Controls.Add((Control)this.label11);
            this.Controls.Add((Control)this.rosalia_preferenceSet);
            //this.Controls.Add((Control)this.label12);
            //this.Controls.Add((Control)this.label7);
            this.Controls.Add((Control)this.sam_exclusionSet);
            //this.Controls.Add((Control)this.label8);
            this.Controls.Add((Control)this.sam_preferenceSet);
/*            this.Controls.Add((Control)this.label9);
            this.Controls.Add((Control)this.label6);*/
            this.Controls.Add((Control)this.liam_exclusionSet);
            //this.Controls.Add((Control)this.label5);
            this.Controls.Add((Control)this.liam_preferenceSet);
      /*      this.Controls.Add((Control)this.label4);
            this.Controls.Add((Control)this.label3);*/
            this.Controls.Add((Control)this.dateEnd);
            //this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.dateStart);
/*            this.Controls.Add((Control)this.label1);
*/            this.Controls.Add((Control)this.meetingInitiator);
            this.Controls.Add((Control)this.button1);
            this.Margin = new Padding(2);
            this.Name = nameof(SchedulerUI);
            this.Text = "Meeting Scheduler System";
            this.meetingDetails.ResumeLayout(false);
            this.meetingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
  }
}
