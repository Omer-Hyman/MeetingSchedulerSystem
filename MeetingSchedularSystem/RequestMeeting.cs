using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  public partial class RequestMeeting : Form
  {
    private Meeting meeting;
    private Regex rx;
    private Button submitMeetingButton;
    private IContainer components = (IContainer)null;
    private TextBox meetingInitiator;
    private TextBox dateStart;
    private TextBox dateEnd;
    private TextBox locationRequest;
    private TextBox equipmentBox;
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
    private Label initLabel;
    private Label label6;
    private Label label20;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label equipmentTitle;
    private Label locationTitle;
    private Label liamLabel;
    private Label samLabel;
    private Label rosaliaLabel;
    private Label heatherLabel;
    private Label endDate;
    private Label startDate;
    private Label meetingSlot;
    public RequestMeeting(string initiator)
    {
      InitializeComponent();
      meetingInitiator.Text = initiator;
    }

    private void submitMeetingButton_Click(object sender, EventArgs e)
    {
      string[] dateStart = this.dateStart.Text.Split('/');
      string[] dateEnd = this.dateEnd.Text.Split('/');
      DateTime startDate = new DateTime(int.Parse(dateStart[2]), int.Parse(dateStart[1]), int.Parse(dateStart[0]));
      DateTime endDate = new DateTime(int.Parse(dateEnd[2]), int.Parse(dateEnd[1]), int.Parse(dateEnd[0]));
      string equipment = this.equipmentBox.Text;
      string location = this.locationRequest.Text;
      this.liamResult.Text = "Waiting";
      this.rosaliaResult.Text = "Waiting";
      this.heatherResult.Text = "Waiting";
      this.samResult.Text = "Waiting";
      this.meetingStatus.Text = "Not yet planned";
      this.meetingErrors.Text = "No errors";
      this.meetingDate.Text = "Not yet planned";
      this.meetingSlotNo.Text = "Not planned";//field population


      // UI components, set values
      try
      {
        this.meeting = new Meeting(new Initiator(this.meetingInitiator.Text.Trim()), startDate, endDate, location, equipment); //location);//meeting constructor
        foreach (Personas persona in this.GetPersonas())//
          this.meeting.addPersona(persona);
        try
        {
          MeetingSlot topSlot = this.meeting.findTopMS();
          this.meetingErrors.Text = "No Errors";
          this.meeting.setStatus("Scheduled");
          this.meetingDate.Text = topSlot.date.ToShortDateString();
          // slot no
          this.meetingSlotNo.Text = "Slot " + topSlot.ID.ToString();
          //this.location.Text = "Location " + topSlot.location.ToString();
          int num = (int)MessageBox.Show("Meeting slot has been found: \n" + topSlot.ToString());
            // explain to users what slots correspond to?
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
      catch (LocationException ex)
            {
                this.meetingErrors.Text = ex.Message;
                int num = (int)MessageBox.Show(ex.Message, "Location conflict", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.meetingStatus.Text = "Error initiating meeting, location conflict";
            }
       catch(EquipmentException ex)
            {
                this.meetingErrors.Text = ex.Message;
                int num = (int)MessageBox.Show(ex.Message, "Equipment conflict", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.meetingStatus.Text = "Error initiating meeting, equipment conflict.";
            }
      catch (Exception er)
      {
        this.meeting.setStatus("Participant error");
        this.meetingErrors.Text = er.Message;
        int num = (int)MessageBox.Show(er.Message, "Personas Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      if (this.meeting == null || !(this.meetingStatus.Text != "Error initiating meeting"))
        return;
      this.meetingStatus.Text = this.meeting.getStatus();
    }

    private List<Personas> GetPersonas()
    {
      List<Personas> personaList = new List<Personas>();
       this.rx = new Regex("(\\d{1,2})/(\\d{1,2})/(\\d{4}) Slot (\\d) Room (\\d) Equipment (\\d)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

      // regex would go here if we can't figure out a better way
      // had to do it for one of thoose placement assessment things so be reyt

      bool check = true;

      // persona instance 1: Liam
      Personas persona1 = new Personas("Liam Williams", 5, true);//create persona
      this.liamResult.Text = "";
      try//
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
      Personas persona2 = new Personas("Sam Scott", 2, false);
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
      catch (MSlotException ex)//PARTICPANTS ERROR COMES FROM HERE NO MATTER WHAT USER IS CHOSEN (line 173)
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
      Personas persona3 = new Personas("Rosalia Cortez", 3, false);
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
      Personas persona4 = new Personas("Heather McLean", 1, false);
      this.heatherResult.Text = "";
      try
      {
        this.fillPersonaSet(persona4, "preference", this.heather_preferenceSet.Text);

      }
      catch (MSlotException ex)//cant find persona
      {
        check = false;
        TextBox heatherResult = this.heatherResult;
        heatherResult.Text = heatherResult.Text + ex.Message + "\n";
      }
      try
      {
        this.fillPersonaSet(persona4, "exclusion", this.heather_exclusionSet.Text);
      }
      catch (MSlotException ex)
      {
        check = false;
        TextBox heatherResult = this.heatherResult;
        heatherResult.Text = heatherResult.Text + ex.Message + "\n";
      }
      if (this.heatherResult.Text == "")
        this.heatherResult.Text = "Okay";

      personaList.Add(persona1);//adding personas to persona list
      personaList.Add(persona2);
      personaList.Add(persona3);
      personaList.Add(persona4);
      if (!check)
      {
        throw new Exception("Error with personas");
      }
      return personaList;

    }

    private void fillPersonaSet(Personas persona, string setType, string setText)//
    {
      foreach (Match match in this.rx.Matches(setText))
      {
        GroupCollection groups = match.Groups;
        // ALSO COMPARE LOCATIONS, EQUIPMENT HERE
        string location = "Room 1";
        string equipment = "Equipment 1";
        DateTime dateTime = new DateTime(int.Parse(groups[3].Value), int.Parse(groups[2].Value), int.Parse(groups[1].Value));
        // this is comparison city: check to see if we need to throw an exception (location, equipment conflict etc)
        if (string.Compare(location, this.meeting.getLocation()) < 0)
                {
                    throw new LocationException(match.ToString() + " ( " + (setType == "preference" ? "pref" : "exc") + ") is a location conflict.", persona);

                }
        if (String.Compare(equipment, this.meeting.getEquipment()) < 0)
                {
                    throw new EquipmentException(match.ToString() + " (" + (setType == "preference" ? "pref" : "exc") + ") is an equipment conflict.", persona);
                }
        if (DateTime.Compare(dateTime, this.meeting.getStartDate()) < 0)
          throw new MSlotException(match.ToString() + " (" + (setType == "preference" ? "pref" : "exc") + ") is before the minimum date of the meeting.", persona); // improve, text changes
        if (DateTime.Compare(dateTime, this.meeting.getEndDate()) > 0)
          throw new MSlotException(match.ToString() + " (" + (setType == "preference" ? "pref" : "exc") + ") is after the maximum date of the meeting.", persona);
        MeetingSlot meetingSlot = new MeetingSlot(dateTime, int.Parse(groups[4].Value), location);
        if (setType == "preference")
          persona.addToPSet(meetingSlot);
        else
          persona.addToESet(meetingSlot);
      }

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


    //newMeeting.Date = datePicker.Value; //date

    /*for (int i = 0; i < guestList.CheckedItems.Count; i++)
    {
      newMeeting.Guests[i] = guestList.CheckedItems[i].ToString();//guests
    }
*/

    //importance level - attached to personas
    //location

    private void guestList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void RequestMeeting_Load(object sender, EventArgs e)
    {

    }
    private void InitializeComponent()
    {
      this.submitMeetingButton = new System.Windows.Forms.Button();
      this.meetingInitiator = new System.Windows.Forms.TextBox();
      this.dateStart = new System.Windows.Forms.TextBox();
      this.dateEnd = new System.Windows.Forms.TextBox();
      this.locationRequest = new System.Windows.Forms.TextBox();
      this.locationTitle = new System.Windows.Forms.Label();
      this.equipmentBox = new System.Windows.Forms.TextBox();
      this.liam_preferenceSet = new System.Windows.Forms.TextBox();
      this.liam_exclusionSet = new System.Windows.Forms.TextBox();
      this.sam_exclusionSet = new System.Windows.Forms.TextBox();
      this.sam_preferenceSet = new System.Windows.Forms.TextBox();
      this.rosalia_exclusionSet = new System.Windows.Forms.TextBox();
      this.rosalia_preferenceSet = new System.Windows.Forms.TextBox();
      this.heather_exclusionSet = new System.Windows.Forms.TextBox();
      this.heather_preferenceSet = new System.Windows.Forms.TextBox();
      this.initLabel = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
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
      this.equipmentTitle = new System.Windows.Forms.Label();
      this.liamLabel = new System.Windows.Forms.Label();
      this.samLabel = new System.Windows.Forms.Label();
      this.rosaliaLabel = new System.Windows.Forms.Label();
      this.heatherLabel = new System.Windows.Forms.Label();
      this.endDate = new System.Windows.Forms.Label();
      this.startDate = new System.Windows.Forms.Label();
      this.meetingDetails.SuspendLayout();
      this.SuspendLayout();
      // 
      // submitMeetingButton
      // 
      this.submitMeetingButton.Location = new System.Drawing.Point(476, 197);
      this.submitMeetingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.submitMeetingButton.Name = "submitMeetingButton";
      this.submitMeetingButton.Size = new System.Drawing.Size(201, 51);
      this.submitMeetingButton.TabIndex = 0;
      this.submitMeetingButton.Text = "Setup Meeting";
      this.submitMeetingButton.UseVisualStyleBackColor = true;
      this.submitMeetingButton.Click += new System.EventHandler(this.submitMeetingButton_Click);
      // 
      // meetingInitiator
      // 
      this.meetingInitiator.Location = new System.Drawing.Point(572, 32);
      this.meetingInitiator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingInitiator.Name = "meetingInitiator";
      this.meetingInitiator.Size = new System.Drawing.Size(135, 22);
      this.meetingInitiator.TabIndex = 1;
      this.meetingInitiator.Text = "Liam Williams";
      this.meetingInitiator.TextChanged += new System.EventHandler(this.meetingInitiator_TextChanged);
      // 
      // dateStart
      // 
      this.dateStart.Location = new System.Drawing.Point(572, 62);
      this.dateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dateStart.Name = "dateStart";
      this.dateStart.Size = new System.Drawing.Size(135, 22);
      this.dateStart.TabIndex = 3;
      this.dateStart.Text = "01/01/2021";
      // 
      // dateEnd
      // 
      this.dateEnd.Location = new System.Drawing.Point(572, 94);
      this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dateEnd.Name = "dateEnd";
      this.dateEnd.Size = new System.Drawing.Size(135, 22);
      this.dateEnd.TabIndex = 5;
      this.dateEnd.Text = "03/01/2021";
      // 
      // locationRequest
      // 
      this.locationRequest.Location = new System.Drawing.Point(440, 154);
      this.locationRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.locationRequest.Name = "locationRequest";
      this.locationRequest.Size = new System.Drawing.Size(105, 22);
      this.locationRequest.TabIndex = 4;
      this.locationRequest.Text = "Room 1";
      // 
      // locationTitle
      // 
      this.locationTitle.Location = new System.Drawing.Point(437, 122);
      this.locationTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.locationTitle.Name = "locationTitle";
      this.locationTitle.Size = new System.Drawing.Size(93, 20);
      this.locationTitle.TabIndex = 70;
      this.locationTitle.Text = "Location:";
      // 
      // equipmentBox
      // 
      this.equipmentBox.Location = new System.Drawing.Point(569, 154);
      this.equipmentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.equipmentBox.Name = "equipmentBox";
      this.equipmentBox.Size = new System.Drawing.Size(138, 22);
      this.equipmentBox.TabIndex = 5;
      this.equipmentBox.Text = "Equipment 1";
      // 
      // liam_preferenceSet
      // 
      this.liam_preferenceSet.Location = new System.Drawing.Point(16, 308);
      this.liam_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liam_preferenceSet.Multiline = true;
      this.liam_preferenceSet.Name = "liam_preferenceSet";
      this.liam_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.liam_preferenceSet.TabIndex = 8;
      this.liam_preferenceSet.Text = "01/01/2021 Slot 1 Room 1 Equipment 1\r\n01/01/2021 Slot 2 Room 1 Equipment 1";
      // 
      // liam_exclusionSet
      // 
      this.liam_exclusionSet.Location = new System.Drawing.Point(16, 431);
      this.liam_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liam_exclusionSet.Multiline = true;
      this.liam_exclusionSet.Name = "liam_exclusionSet";
      this.liam_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.liam_exclusionSet.TabIndex = 10;
      this.liam_exclusionSet.Text = "02/01/2021 Slot 1 Room 2 Equipment 2\r\n02/01/2021 Slot 2 Room 2 Equipment 2";
      // 
      // sam_exclusionSet
      // 
      this.sam_exclusionSet.Location = new System.Drawing.Point(309, 431);
      this.sam_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sam_exclusionSet.Multiline = true;
      this.sam_exclusionSet.Name = "sam_exclusionSet";
      this.sam_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.sam_exclusionSet.TabIndex = 15;
      this.sam_exclusionSet.Text = "02/01/2021 Slot 1 Room 2 Equipment 2\r\n02/01/2021 Slot 2 Room 2 Equipment 2";
      // 
      // sam_preferenceSet
      // 
      this.sam_preferenceSet.Location = new System.Drawing.Point(309, 308);
      this.sam_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.sam_preferenceSet.Multiline = true;
      this.sam_preferenceSet.Name = "sam_preferenceSet";
      this.sam_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.sam_preferenceSet.TabIndex = 13;
      this.sam_preferenceSet.Text = "01/01/2021 Slot 1 Room 1 Equipment 1\r\n01/01/2021 Slot 2 Room 1 Equipment 1";
      // 
      // rosalia_exclusionSet
      // 
      this.rosalia_exclusionSet.Location = new System.Drawing.Point(603, 431);
      this.rosalia_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosalia_exclusionSet.Multiline = true;
      this.rosalia_exclusionSet.Name = "rosalia_exclusionSet";
      this.rosalia_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.rosalia_exclusionSet.TabIndex = 20;
      this.rosalia_exclusionSet.Text = "02/01/2021 Slot 1 Room 2 Equipment 2\r\n02/01/2021 Slot 2 Room 2 Equipment 2";
      // 
      // rosalia_preferenceSet
      // 
      this.rosalia_preferenceSet.Location = new System.Drawing.Point(603, 308);
      this.rosalia_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosalia_preferenceSet.Multiline = true;
      this.rosalia_preferenceSet.Name = "rosalia_preferenceSet";
      this.rosalia_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.rosalia_preferenceSet.TabIndex = 18;
      this.rosalia_preferenceSet.Text = "01/01/2021 Slot 1 Room 1 Equipment 1\r\n01/01/2021 Slot 2 Room 1 Equipment 1";
      // 
      // heather_exclusionSet
      // 
      this.heather_exclusionSet.Location = new System.Drawing.Point(896, 431);
      this.heather_exclusionSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heather_exclusionSet.Multiline = true;
      this.heather_exclusionSet.Name = "heather_exclusionSet";
      this.heather_exclusionSet.Size = new System.Drawing.Size(265, 73);
      this.heather_exclusionSet.TabIndex = 25;
      this.heather_exclusionSet.Text = "02/01/2021 Slot 1 Room 2 Equipment 2\r\n02/01/2021 Slot 2 Room 2 Equipment 2";
      // 
      // heather_preferenceSet
      // 
      this.heather_preferenceSet.Location = new System.Drawing.Point(896, 308);
      this.heather_preferenceSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.heather_preferenceSet.Multiline = true;
      this.heather_preferenceSet.Name = "heather_preferenceSet";
      this.heather_preferenceSet.Size = new System.Drawing.Size(265, 73);
      this.heather_preferenceSet.TabIndex = 23;
      this.heather_preferenceSet.Text = "01/01/2021 Slot 1 Room 1 Equipment 1\r\n01/01/2021 Slot 2 Room 1 Equipment 1";
      // 
      // initLabel
      // 
      this.initLabel.Location = new System.Drawing.Point(439, 32);
      this.initLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.initLabel.Name = "initLabel";
      this.initLabel.Size = new System.Drawing.Size(82, 20);
      this.initLabel.TabIndex = 69;
      this.initLabel.Text = "Initiator:";
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(0, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(100, 23);
      this.label6.TabIndex = 0;
      this.label6.Text = "Exclusion Set";
      // 
      // label20
      // 
      this.label20.Location = new System.Drawing.Point(0, 0);
      this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(200, 44);
      this.label20.TabIndex = 46;
      // 
      // label22
      // 
      this.label22.Location = new System.Drawing.Point(0, 0);
      this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(200, 44);
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
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(8, 20);
      this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(48, 17);
      this.label24.TabIndex = 49;
      this.label24.Text = "Status";
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Location = new System.Drawing.Point(271, 20);
      this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(92, 17);
      this.label25.TabIndex = 51;
      this.label25.Text = "Meeting Date";
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
      this.meetingDetails.Location = new System.Drawing.Point(245, 646);
      this.meetingDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDetails.Name = "meetingDetails";
      this.meetingDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDetails.Size = new System.Drawing.Size(781, 136);
      this.meetingDetails.TabIndex = 32;
      this.meetingDetails.TabStop = false;
      this.meetingDetails.Text = "Meeting Details";
      // 
      // meetingErrors
      // 
      this.meetingErrors.Location = new System.Drawing.Point(12, 99);
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
      this.meetingSlotNo.Location = new System.Drawing.Point(524, 40);
      this.meetingSlotNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingSlotNo.Name = "meetingSlotNo";
      this.meetingSlotNo.ReadOnly = true;
      this.meetingSlotNo.Size = new System.Drawing.Size(231, 22);
      this.meetingSlotNo.TabIndex = 52;
      this.meetingSlotNo.Text = "Not Planned";
      // 
      // meetingDate
      // 
      this.meetingDate.Location = new System.Drawing.Point(271, 40);
      this.meetingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingDate.Name = "meetingDate";
      this.meetingDate.ReadOnly = true;
      this.meetingDate.Size = new System.Drawing.Size(231, 22);
      this.meetingDate.TabIndex = 50;
      this.meetingDate.Text = "Not Planned";
      // 
      // meetingStatus
      // 
      this.meetingStatus.Location = new System.Drawing.Point(12, 40);
      this.meetingStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.meetingStatus.Name = "meetingStatus";
      this.meetingStatus.ReadOnly = true;
      this.meetingStatus.Size = new System.Drawing.Size(231, 22);
      this.meetingStatus.TabIndex = 48;
      this.meetingStatus.Text = "Not Planned";
      // 
      // liamResult
      // 
      this.liamResult.Location = new System.Drawing.Point(16, 554);
      this.liamResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.liamResult.Multiline = true;
      this.liamResult.Name = "liamResult";
      this.liamResult.ReadOnly = true;
      this.liamResult.Size = new System.Drawing.Size(265, 48);
      this.liamResult.TabIndex = 38;
      this.liamResult.Text = "N/A";
      this.liamResult.TextChanged += new System.EventHandler(this.liamResult_TextChanged);
      // 
      // samResult
      // 
      this.samResult.Location = new System.Drawing.Point(309, 554);
      this.samResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.samResult.Multiline = true;
      this.samResult.Name = "samResult";
      this.samResult.ReadOnly = true;
      this.samResult.Size = new System.Drawing.Size(265, 48);
      this.samResult.TabIndex = 40;
      this.samResult.Text = "N/A";
      this.samResult.TextChanged += new System.EventHandler(this.samResult_TextChanged);
      // 
      // heatherResult
      // 
      this.heatherResult.Location = new System.Drawing.Point(896, 554);
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
      this.rosaliaResult.Location = new System.Drawing.Point(603, 554);
      this.rosaliaResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosaliaResult.Multiline = true;
      this.rosaliaResult.Name = "rosaliaResult";
      this.rosaliaResult.ReadOnly = true;
      this.rosaliaResult.Size = new System.Drawing.Size(265, 48);
      this.rosaliaResult.TabIndex = 42;
      this.rosaliaResult.Text = "N/A";
      // 
      // equipmentTitle
      // 
      this.equipmentTitle.Location = new System.Drawing.Point(569, 126);
      this.equipmentTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.equipmentTitle.Name = "equipmentTitle";
      this.equipmentTitle.Size = new System.Drawing.Size(93, 20);
      this.equipmentTitle.TabIndex = 70;
      this.equipmentTitle.Text = "Equipment:";
      // 
      // liamLabel
      // 
      this.liamLabel.AutoSize = true;
      this.liamLabel.Location = new System.Drawing.Point(13, 277);
      this.liamLabel.Name = "liamLabel";
      this.liamLabel.Size = new System.Drawing.Size(151, 17);
      this.liamLabel.TabIndex = 71;
      this.liamLabel.Text = "Liam\'s date range sets";
      // 
      // samLabel
      // 
      this.samLabel.AutoSize = true;
      this.samLabel.Location = new System.Drawing.Point(306, 277);
      this.samLabel.Name = "samLabel";
      this.samLabel.Size = new System.Drawing.Size(149, 17);
      this.samLabel.TabIndex = 72;
      this.samLabel.Text = "Sam\'s date range sets";
      // 
      // rosaliaLabel
      // 
      this.rosaliaLabel.AutoSize = true;
      this.rosaliaLabel.Location = new System.Drawing.Point(600, 277);
      this.rosaliaLabel.Name = "rosaliaLabel";
      this.rosaliaLabel.Size = new System.Drawing.Size(168, 17);
      this.rosaliaLabel.TabIndex = 73;
      this.rosaliaLabel.Text = "Rosalia\'s date range sets";
      // 
      // heatherLabel
      // 
      this.heatherLabel.AutoSize = true;
      this.heatherLabel.Location = new System.Drawing.Point(893, 277);
      this.heatherLabel.Name = "heatherLabel";
      this.heatherLabel.Size = new System.Drawing.Size(172, 17);
      this.heatherLabel.TabIndex = 74;
      this.heatherLabel.Text = "Heather\'s date range sets";
      // 
      // endDate
      // 
      this.endDate.Location = new System.Drawing.Point(437, 94);
      this.endDate.Margin = new System.Windows.Forms.Padding(4);
      this.endDate.Name = "endDate";
      this.endDate.Size = new System.Drawing.Size(127, 20);
      this.endDate.TabIndex = 75;
      this.endDate.Text = "End Date Range:";
      // 
      // startDate
      // 
      this.startDate.Location = new System.Drawing.Point(437, 62);
      this.startDate.Margin = new System.Windows.Forms.Padding(4);
      this.startDate.Name = "startDate";
      this.startDate.Size = new System.Drawing.Size(127, 20);
      this.startDate.TabIndex = 76;
      this.startDate.Text = "Start Date Range:";
      // 
      // RequestMeeting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1267, 842);
      this.Controls.Add(this.startDate);
      this.Controls.Add(this.endDate);
      this.Controls.Add(this.heatherLabel);
      this.Controls.Add(this.rosaliaLabel);
      this.Controls.Add(this.samLabel);
      this.Controls.Add(this.liamLabel);
      this.Controls.Add(this.heatherResult);
      this.Controls.Add(this.rosaliaResult);
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
      this.Controls.Add(this.submitMeetingButton);
      this.Controls.Add(this.equipmentTitle);
      this.Controls.Add(this.equipmentBox);
      this.Controls.Add(this.locationRequest);
      this.Controls.Add(this.locationTitle);
      this.Controls.Add(this.initLabel);
      this.Name = "RequestMeeting";
      this.Text = "Request Meeting";
      this.Load += new System.EventHandler(this.RequestMeeting_Load_1);
      this.meetingDetails.ResumeLayout(false);
      this.meetingDetails.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void meetingInitiator_TextChanged(object sender, EventArgs e)
    {

    }

    private void RequestMeeting_Load_1(object sender, EventArgs e)
    {

    }

        private void liamResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void samResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
