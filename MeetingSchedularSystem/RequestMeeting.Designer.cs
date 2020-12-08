namespace MeetingSchedularSystem
{
  partial class RequestMeeting
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.datePicker = new System.Windows.Forms.DateTimePicker();
      this.dateRangeLabel = new System.Windows.Forms.Label();
      this.inviteGuests = new System.Windows.Forms.Label();
      this.guestList = new System.Windows.Forms.CheckedListBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.meetingDescription = new System.Windows.Forms.TextBox();
      this.submitMeetingButton = new System.Windows.Forms.Button();
      this.equipmentLabel = new System.Windows.Forms.Label();
      this.cancelMeetingButton = new System.Windows.Forms.Button();
      this.meetingNameLabel = new System.Windows.Forms.Label();
      this.meetingName = new System.Windows.Forms.TextBox();
      this.equipmentList = new System.Windows.Forms.CheckedListBox();
      this.locationLabel = new System.Windows.Forms.Label();
      this.locationList = new System.Windows.Forms.CheckedListBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.dateLabelTo = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // datePicker
      // 
      this.datePicker.AllowDrop = true;
      this.datePicker.CustomFormat = "";
      this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.datePicker.Location = new System.Drawing.Point(38, 127);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(189, 22);
      this.datePicker.TabIndex = 1;
      this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // dateRangeLabel
      // 
      this.dateRangeLabel.AutoSize = true;
      this.dateRangeLabel.Location = new System.Drawing.Point(35, 103);
      this.dateRangeLabel.Name = "dateRangeLabel";
      this.dateRangeLabel.Size = new System.Drawing.Size(144, 21);
      this.dateRangeLabel.TabIndex = 2;
      this.dateRangeLabel.Text = "Date range from:";
      // 
      // inviteGuests
      // 
      this.inviteGuests.AutoSize = true;
      this.inviteGuests.Location = new System.Drawing.Point(38, 221);
      this.inviteGuests.Name = "inviteGuests";
      this.inviteGuests.Size = new System.Drawing.Size(91, 17);
      this.inviteGuests.TabIndex = 3;
      this.inviteGuests.Text = "Invite guests:";
      this.inviteGuests.Click += new System.EventHandler(this.label1_Click);
      // 
      // guestList
      // 
      this.guestList.CheckOnClick = true;
      this.guestList.FormattingEnabled = true;
      this.guestList.Items.AddRange(new object[] {
            "Mehmet-Bulent Özcan",
            "Heather McLean",
            "Liam Williams",
            "Sam Scott",
            "Rosalia Cortez"});
      this.guestList.Location = new System.Drawing.Point(38, 241);
      this.guestList.Name = "guestList";
      this.guestList.Size = new System.Drawing.Size(189, 106);
      this.guestList.TabIndex = 4;
      this.guestList.SelectedIndexChanged += new System.EventHandler(this.guestList_SelectedIndexChanged);
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(35, 350);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(135, 17);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Meeting description:";
      // 
      // meetingDescription
      // 
      this.meetingDescription.Location = new System.Drawing.Point(38, 370);
      this.meetingDescription.Multiline = true;
      this.meetingDescription.Name = "meetingDescription";
      this.meetingDescription.Size = new System.Drawing.Size(417, 77);
      this.meetingDescription.TabIndex = 7;
      // 
      // submitMeetingButton
      // 
      this.submitMeetingButton.Location = new System.Drawing.Point(38, 469);
      this.submitMeetingButton.Name = "submitMeetingButton";
      this.submitMeetingButton.Size = new System.Drawing.Size(176, 48);
      this.submitMeetingButton.TabIndex = 8;
      this.submitMeetingButton.Text = "Submit Meeting Request";
      this.submitMeetingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.submitMeetingButton.UseVisualStyleBackColor = true;
      this.submitMeetingButton.Click += new System.EventHandler(this.submitMeetingButton_Click);
      // 
      // equipmentLabel
      // 
      this.equipmentLabel.AutoSize = true;
      this.equipmentLabel.Location = new System.Drawing.Point(247, 255);
      this.equipmentLabel.Name = "equipmentLabel";
      this.equipmentLabel.Size = new System.Drawing.Size(79, 17);
      this.equipmentLabel.TabIndex = 9;
      this.equipmentLabel.Text = "Equipment:";
      this.equipmentLabel.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // cancelMeetingButton
      // 
      this.cancelMeetingButton.Location = new System.Drawing.Point(322, 469);
      this.cancelMeetingButton.Name = "cancelMeetingButton";
      this.cancelMeetingButton.Size = new System.Drawing.Size(133, 48);
      this.cancelMeetingButton.TabIndex = 11;
      this.cancelMeetingButton.Text = "Cancel";
      this.cancelMeetingButton.UseVisualStyleBackColor = true;
      this.cancelMeetingButton.Click += new System.EventHandler(this.cancelMeetingButton_Click);
      // 
      // meetingNameLabel
      // 
      this.meetingNameLabel.AutoSize = true;
      this.meetingNameLabel.Location = new System.Drawing.Point(38, 18);
      this.meetingNameLabel.Name = "meetingNameLabel";
      this.meetingNameLabel.Size = new System.Drawing.Size(101, 17);
      this.meetingNameLabel.TabIndex = 15;
      this.meetingNameLabel.Text = "Meeting name:";
      // 
      // meetingName
      // 
      this.meetingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.meetingName.Location = new System.Drawing.Point(38, 55);
      this.meetingName.Name = "meetingName";
      this.meetingName.Size = new System.Drawing.Size(417, 38);
      this.meetingName.TabIndex = 16;
      this.meetingName.Text = "New Meeting";
      // 
      // equipmentList
      // 
      this.equipmentList.CheckOnClick = true;
      this.equipmentList.FormattingEnabled = true;
      this.equipmentList.Items.AddRange(new object[] {
            "Projector",
            "Whiteboard",
            "Desktop"});
      this.equipmentList.Location = new System.Drawing.Point(250, 275);
      this.equipmentList.Name = "equipmentList";
      this.equipmentList.Size = new System.Drawing.Size(205, 72);
      this.equipmentList.TabIndex = 17;
      // 
      // locationLabel
      // 
      this.locationLabel.AutoSize = true;
      this.locationLabel.Location = new System.Drawing.Point(247, 107);
      this.locationLabel.Name = "locationLabel";
      this.locationLabel.Size = new System.Drawing.Size(66, 17);
      this.locationLabel.TabIndex = 18;
      this.locationLabel.Text = "Location:";
      // 
      // locationList
      // 
      this.locationList.CheckOnClick = true;
      this.locationList.FormattingEnabled = true;
      this.locationList.Items.AddRange(new object[] {
            "Meeting Room 1",
            "Meeting Room 2",
            "Meeting Room 3",
            "Meeting Room 4"});
      this.locationList.Location = new System.Drawing.Point(250, 127);
      this.locationList.Name = "locationList";
      this.locationList.Size = new System.Drawing.Size(205, 89);
      this.locationList.TabIndex = 19;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.AllowDrop = true;
      this.dateTimePicker1.CustomFormat = "";
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(38, 181);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
      this.dateTimePicker1.TabIndex = 20;
      // 
      // dateLabelTo
      // 
      this.dateLabelTo.AutoSize = true;
      this.dateLabelTo.Location = new System.Drawing.Point(35, 161);
      this.dateLabelTo.Name = "dateLabelTo";
      this.dateLabelTo.Size = new System.Drawing.Size(29, 17);
      this.dateLabelTo.TabIndex = 21;
      this.dateLabelTo.Text = "To:";
      // 
      // RequestMeeting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(499, 550);
      this.Controls.Add(this.dateLabelTo);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.locationList);
      this.Controls.Add(this.locationLabel);
      this.Controls.Add(this.equipmentList);
      this.Controls.Add(this.meetingName);
      this.Controls.Add(this.meetingNameLabel);
      this.Controls.Add(this.cancelMeetingButton);
      this.Controls.Add(this.equipmentLabel);
      this.Controls.Add(this.submitMeetingButton);
      this.Controls.Add(this.meetingDescription);
      this.Controls.Add(this.descriptionLabel);
      this.Controls.Add(this.guestList);
      this.Controls.Add(this.inviteGuests);
      this.Controls.Add(this.dateRangeLabel);
      this.Controls.Add(this.datePicker);
      this.Name = "RequestMeeting";
      this.Text = "RequestMeeting";
      this.Load += new System.EventHandler(this.RequestMeeting_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DateTimePicker datePicker;
    private System.Windows.Forms.Label dateRangeLabel;
    private System.Windows.Forms.Label inviteGuests;
    private System.Windows.Forms.CheckedListBox guestList;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.TextBox meetingDescription;
    private System.Windows.Forms.Button submitMeetingButton;
    private System.Windows.Forms.Label equipmentLabel;
    private System.Windows.Forms.Button cancelMeetingButton;
    private System.Windows.Forms.Label meetingNameLabel;
    private System.Windows.Forms.TextBox meetingName;
    private System.Windows.Forms.CheckedListBox equipmentList;
    private System.Windows.Forms.Label locationLabel;
    private System.Windows.Forms.CheckedListBox locationList;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label dateLabelTo;
  }
}