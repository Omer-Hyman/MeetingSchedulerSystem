using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp2;


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
            persona.Show();
            */

      string[] dateStart = this.dateStart.Text.Split('/');
      string[] dateEnd = this.dateEnd.Text.Split('/');
      DateTime startDate = new DateTime(int.Parse(dateStart[2]), int.Parse(dateStart[1]), int.Parse(dateStart[0]));
      DateTime endDate = new DateTime(int.Parse(dateEnd[2]), int.Parse(dateEnd[1]), int.Parse(dateEnd[0]));
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
      foreach (Match match in this.rx.Matches(setText))
      {
        GroupCollection groups = match.Groups;
        // ALSO COMPARE LOCATIONS, EQUIPMENT HERE
        DateTime dateTime = new DateTime(int.Parse(groups[3].Value), int.Parse(groups[2].Value), int.Parse(groups[1].Value));
        if (DateTime.Compare(dateTime, this.meeting.getStartDate()) < 0)
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
      this.button1 = new System.Windows.Forms.Button();
      this.meetingInitiator = new System.Windows.Forms.TextBox();
      this.dateStart = new System.Windows.Forms.TextBox();
      this.dateEnd = new System.Windows.Forms.TextBox();
      this.liam_preferenceSet = new System.Windows.Forms.TextBox();
      this.liam_exclusionSet = new System.Windows.Forms.TextBox();
      this.sam_exclusionSet = new System.Windows.Forms.TextBox();
      this.sam_preferenceSet = new System.Windows.Forms.TextBox();
      this.rosalia_exclusionSet = new System.Windows.Forms.TextBox();
      this.rosalia_preferenceSet = new System.Windows.Forms.TextBox();
      this.heather_exclusionSet = new System.Windows.Forms.TextBox();
      this.heather_preferenceSet = new System.Windows.Forms.TextBox();
      this.label20 = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.label25 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.meetingDetails = new System.Windows.Forms.GroupBox();
      this.meetingErrors = new System.Windows.Forms.TextBox();
      this.meetingSlot = new System.Windows.Forms.Label();
      this.meetingSlotNo = new System.Windows.Forms.TextBox();
      this.meetingDate = new System.Windows.Forms.TextBox();
      this.meetingStatus = new System.Windows.Forms.TextBox();
      this.liamResult = new System.Windows.Forms.TextBox();
      this.samResult = new System.Windows.Forms.TextBox();
      this.heatherResult = new System.Windows.Forms.TextBox();
      this.rosaliaResult = new System.Windows.Forms.TextBox();
      this.meetingDetails.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(16, 180);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(201, 50);
      this.button1.TabIndex = 0;
      this.button1.Text = "Setup Meeting";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // meetingInitiator
      // 
      this.meetingInitiator.Location = new System.Drawing.Point(16, 37);
      this.meetingInitiator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingInitiator.Name = "meetingInitiator";
      this.meetingInitiator.Size = new System.Drawing.Size(200, 22);
      this.meetingInitiator.TabIndex = 1;
      this.meetingInitiator.Text = "Liam";
      // 
      // dateStart
      // 
      this.dateStart.Location = new System.Drawing.Point(16, 89);
      this.dateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dateStart.Name = "dateStart";
      this.dateStart.Size = new System.Drawing.Size(200, 22);
      this.dateStart.TabIndex = 3;
      this.dateStart.Text = "10/12/2018";
      // 
      // dateEnd
      // 
      this.dateEnd.Location = new System.Drawing.Point(16, 140);
      this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dateEnd.Name = "dateEnd";
      this.dateEnd.Size = new System.Drawing.Size(200, 22);
      this.dateEnd.TabIndex = 5;
      this.dateEnd.Text = "12/12/2018";
      // 
      // liam_preferenceSet
      // 
      this.liam_preferenceSet.Location = new System.Drawing.Point(235, 59);
      this.liam_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liam_preferenceSet.Multiline = true;
      this.liam_preferenceSet.Name = "liam_preferenceSet";
      this.liam_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.liam_preferenceSet.TabIndex = 8;
      this.liam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // liam_exclusionSet
      // 
      this.liam_exclusionSet.Location = new System.Drawing.Point(235, 158);
      this.liam_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liam_exclusionSet.Multiline = true;
      this.liam_exclusionSet.Name = "liam_exclusionSet";
      this.liam_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.liam_exclusionSet.TabIndex = 10;
      this.liam_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
      this.liam_exclusionSet.TextChanged += new System.EventHandler(this.liam_exclusionSet_TextChanged);
      // 
      // sam_exclusionSet
      // 
      this.sam_exclusionSet.Location = new System.Drawing.Point(508, 158);
      this.sam_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sam_exclusionSet.Multiline = true;
      this.sam_exclusionSet.Name = "sam_exclusionSet";
      this.sam_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.sam_exclusionSet.TabIndex = 15;
      this.sam_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
      // 
      // sam_preferenceSet
      // 
      this.sam_preferenceSet.Location = new System.Drawing.Point(508, 59);
      this.sam_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sam_preferenceSet.Multiline = true;
      this.sam_preferenceSet.Name = "sam_preferenceSet";
      this.sam_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.sam_preferenceSet.TabIndex = 13;
      this.sam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // rosalia_exclusionSet
      // 
      this.rosalia_exclusionSet.Location = new System.Drawing.Point(783, 158);
      this.rosalia_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosalia_exclusionSet.Multiline = true;
      this.rosalia_exclusionSet.Name = "rosalia_exclusionSet";
      this.rosalia_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.rosalia_exclusionSet.TabIndex = 20;
      this.rosalia_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
      // 
      // rosalia_preferenceSet
      // 
      this.rosalia_preferenceSet.Location = new System.Drawing.Point(783, 59);
      this.rosalia_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosalia_preferenceSet.Multiline = true;
      this.rosalia_preferenceSet.Name = "rosalia_preferenceSet";
      this.rosalia_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.rosalia_preferenceSet.TabIndex = 18;
      this.rosalia_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // heather_exclusionSet
      // 
      this.heather_exclusionSet.Location = new System.Drawing.Point(1059, 158);
      this.heather_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heather_exclusionSet.Multiline = true;
      this.heather_exclusionSet.Name = "heather_exclusionSet";
      this.heather_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.heather_exclusionSet.TabIndex = 25;
      this.heather_exclusionSet.Text = "11/12/2018 Slot 1\r\n11/12/2018 Slot 2";
      // 
      // heather_preferenceSet
      // 
      this.heather_preferenceSet.Location = new System.Drawing.Point(1059, 59);
      this.heather_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heather_preferenceSet.Multiline = true;
      this.heather_preferenceSet.Name = "heather_preferenceSet";
      this.heather_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.heather_preferenceSet.TabIndex = 23;
      this.heather_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // label20
      // 
      this.label20.Location = new System.Drawing.Point(0, 0);
      this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(133, 28);
      this.label20.TabIndex = 46;
      // 
      // label22
      // 
      this.label22.Location = new System.Drawing.Point(0, 0);
      this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(133, 28);
      this.label22.TabIndex = 45;
      // 
      // label23
      // 
      this.label23.Location = new System.Drawing.Point(0, 0);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(100, 23);
      this.label23.TabIndex = 0;
      // 
      // label24
      // 
      this.label24.Location = new System.Drawing.Point(0, 0);
      this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(133, 28);
      this.label24.TabIndex = 57;
      // 
      // label25
      // 
      this.label25.Location = new System.Drawing.Point(0, 0);
      this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(133, 28);
      this.label25.TabIndex = 56;
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Location = new System.Drawing.Point(8, 79);
      this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(47, 17);
      this.label26.TabIndex = 55;
      this.label26.Text = "Errors";
      // 
      // meetingDetails
      // 
      this.meetingDetails.Controls.Add(this.label26);
      this.meetingDetails.Controls.Add(this.meetingErrors);
      this.meetingDetails.Controls.Add(this.meetingSlot);
      this.meetingDetails.Controls.Add(this.meetingSlotNo);
      this.meetingDetails.Controls.Add(this.label25);
      this.meetingDetails.Controls.Add(this.meetingDate);
      this.meetingDetails.Controls.Add(this.label24);
      this.meetingDetails.Controls.Add(this.meetingStatus);
      this.meetingDetails.Location = new System.Drawing.Point(372, 334);
      this.meetingDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDetails.Name = "meetingDetails";
      this.meetingDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDetails.Size = new System.Drawing.Size(781, 137);
      this.meetingDetails.TabIndex = 32;
      this.meetingDetails.TabStop = false;
      this.meetingDetails.Text = "Meeting Details";
      // 
      // meetingErrors
      // 
      this.meetingErrors.Location = new System.Drawing.Point(12, 98);
      this.meetingErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingErrors.Name = "meetingErrors";
      this.meetingErrors.ReadOnly = true;
      this.meetingErrors.Size = new System.Drawing.Size(743, 22);
      this.meetingErrors.TabIndex = 54;
      this.meetingErrors.Text = "No Errors";
      // 
      // meetingSlot
      // 
      this.meetingSlot.AutoSize = true;
      this.meetingSlot.Location = new System.Drawing.Point(520, 20);
      this.meetingSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.meetingSlot.Name = "meetingSlot";
      this.meetingSlot.Size = new System.Drawing.Size(86, 17);
      this.meetingSlot.TabIndex = 53;
      this.meetingSlot.Text = "Meeting Slot";
      // 
      // meetingSlotNo
      // 
      this.meetingSlotNo.Location = new System.Drawing.Point(524, 39);
      this.meetingSlotNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingSlotNo.Name = "meetingSlotNo";
      this.meetingSlotNo.ReadOnly = true;
      this.meetingSlotNo.Size = new System.Drawing.Size(231, 22);
      this.meetingSlotNo.TabIndex = 52;
      this.meetingSlotNo.Text = "Not Planned";
      // 
      // meetingDate
      // 
      this.meetingDate.Location = new System.Drawing.Point(271, 39);
      this.meetingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDate.Name = "meetingDate";
      this.meetingDate.ReadOnly = true;
      this.meetingDate.Size = new System.Drawing.Size(231, 22);
      this.meetingDate.TabIndex = 50;
      this.meetingDate.Text = "Not Planned";
      // 
      // meetingStatus
      // 
      this.meetingStatus.Location = new System.Drawing.Point(12, 39);
      this.meetingStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingStatus.Name = "meetingStatus";
      this.meetingStatus.ReadOnly = true;
      this.meetingStatus.Size = new System.Drawing.Size(231, 22);
      this.meetingStatus.TabIndex = 48;
      this.meetingStatus.Text = "Not Planned";
      // 
      // liamResult
      // 
      this.liamResult.Location = new System.Drawing.Point(235, 255);
      this.liamResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liamResult.Multiline = true;
      this.liamResult.Name = "liamResult";
      this.liamResult.ReadOnly = true;
      this.liamResult.Size = new System.Drawing.Size(265, 48);
      this.liamResult.TabIndex = 38;
      this.liamResult.Text = "N/A";
      // 
      // samResult
      // 
      this.samResult.Location = new System.Drawing.Point(508, 255);
      this.samResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.samResult.Multiline = true;
      this.samResult.Name = "samResult";
      this.samResult.ReadOnly = true;
      this.samResult.Size = new System.Drawing.Size(265, 48);
      this.samResult.TabIndex = 40;
      this.samResult.Text = "N/A";
      // 
      // heatherResult
      // 
      this.heatherResult.Location = new System.Drawing.Point(1059, 255);
      this.heatherResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heatherResult.Multiline = true;
      this.heatherResult.Name = "heatherResult";
      this.heatherResult.ReadOnly = true;
      this.heatherResult.Size = new System.Drawing.Size(265, 48);
      this.heatherResult.TabIndex = 44;
      this.heatherResult.Text = "N/A";
      // 
      // rosaliaResult
      // 
      this.rosaliaResult.Location = new System.Drawing.Point(783, 255);
      this.rosaliaResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosaliaResult.Multiline = true;
      this.rosaliaResult.Name = "rosaliaResult";
      this.rosaliaResult.ReadOnly = true;
      this.rosaliaResult.Size = new System.Drawing.Size(265, 48);
      this.rosaliaResult.TabIndex = 42;
      this.rosaliaResult.Text = "N/A";
      // 
      // SchedulerUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1617, 513);
      this.Controls.Add(this.heatherResult);
      this.Controls.Add(this.label22);
      this.Controls.Add(this.rosaliaResult);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.samResult);
      this.Controls.Add(this.liamResult);
      this.Controls.Add(this.meetingDetails);
      this.Controls.Add(this.heather_exclusionSet);
      this.Controls.Add(this.heather_preferenceSet);
      this.Controls.Add(this.rosalia_exclusionSet);
      this.Controls.Add(this.rosalia_preferenceSet);
      this.Controls.Add(this.sam_exclusionSet);
      this.Controls.Add(this.sam_preferenceSet);
      this.Controls.Add(this.liam_exclusionSet);
      this.Controls.Add(this.liam_preferenceSet);
      this.Controls.Add(this.dateEnd);
      this.Controls.Add(this.dateStart);
      this.Controls.Add(this.meetingInitiator);
      this.Controls.Add(this.button1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "SchedulerUI";
      this.Text = "Meeting Scheduler System";
      this.meetingDetails.ResumeLayout(false);
      this.meetingDetails.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void liam_exclusionSet_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
