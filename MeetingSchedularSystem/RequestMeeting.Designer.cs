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
      this.dateLabel = new System.Windows.Forms.Label();
      this.inviteGuests = new System.Windows.Forms.Label();
      this.guestList = new System.Windows.Forms.CheckedListBox();
      this.newMeetingLabel = new System.Windows.Forms.Label();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.submitMeetingButton = new System.Windows.Forms.Button();
      this.equipmentList = new System.Windows.Forms.CheckedListBox();
      this.equipmentLabel = new System.Windows.Forms.Label();
      this.cancelMeetingButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // datePicker
      // 
      this.datePicker.AllowDrop = true;
      this.datePicker.CustomFormat = "dd/MM/yyyy        hh:mm";
      this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.datePicker.Location = new System.Drawing.Point(40, 96);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(206, 22);
      this.datePicker.TabIndex = 1;
      this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // dateLabel
      // 
      this.dateLabel.AutoSize = true;
      this.dateLabel.Location = new System.Drawing.Point(37, 65);
      this.dateLabel.Name = "dateLabel";
      this.dateLabel.Size = new System.Drawing.Size(42, 17);
      this.dateLabel.TabIndex = 2;
      this.dateLabel.Text = "Date:";
      // 
      // inviteGuests
      // 
      this.inviteGuests.AutoSize = true;
      this.inviteGuests.Location = new System.Drawing.Point(265, 65);
      this.inviteGuests.Name = "inviteGuests";
      this.inviteGuests.Size = new System.Drawing.Size(91, 17);
      this.inviteGuests.TabIndex = 3;
      this.inviteGuests.Text = "Invite guests:";
      this.inviteGuests.Click += new System.EventHandler(this.label1_Click);
      // 
      // guestList
      // 
      this.guestList.FormattingEnabled = true;
      this.guestList.Items.AddRange(new object[] {
            "Mehmet-Bulent Özcan",
            "Heather McLean",
            "Liam Williams",
            "Sam Scott",
            "Rosalia Cortez"});
      this.guestList.Location = new System.Drawing.Point(268, 96);
      this.guestList.Name = "guestList";
      this.guestList.Size = new System.Drawing.Size(189, 89);
      this.guestList.TabIndex = 4;
      // 
      // newMeetingLabel
      // 
      this.newMeetingLabel.AutoSize = true;
      this.newMeetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newMeetingLabel.Location = new System.Drawing.Point(34, 19);
      this.newMeetingLabel.Name = "newMeetingLabel";
      this.newMeetingLabel.Size = new System.Drawing.Size(172, 31);
      this.newMeetingLabel.TabIndex = 5;
      this.newMeetingLabel.Text = "New Meeting";
      this.newMeetingLabel.Click += new System.EventHandler(this.newMeetingLabel_Click);
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(37, 205);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(135, 17);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Meeting description:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(40, 234);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(417, 77);
      this.textBox1.TabIndex = 7;
      // 
      // submitMeetingButton
      // 
      this.submitMeetingButton.Location = new System.Drawing.Point(40, 335);
      this.submitMeetingButton.Name = "submitMeetingButton";
      this.submitMeetingButton.Size = new System.Drawing.Size(176, 48);
      this.submitMeetingButton.TabIndex = 8;
      this.submitMeetingButton.Text = "Submit Meeting Request";
      this.submitMeetingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.submitMeetingButton.UseVisualStyleBackColor = true;
      // 
      // equipmentList
      // 
      this.equipmentList.FormattingEnabled = true;
      this.equipmentList.Items.AddRange(new object[] {
            "Projector",
            "Whiteboard",
            "Desktop"});
      this.equipmentList.Location = new System.Drawing.Point(40, 164);
      this.equipmentList.Name = "equipmentList";
      this.equipmentList.Size = new System.Drawing.Size(206, 21);
      this.equipmentList.TabIndex = 10;
      // 
      // equipmentLabel
      // 
      this.equipmentLabel.AutoSize = true;
      this.equipmentLabel.Location = new System.Drawing.Point(37, 137);
      this.equipmentLabel.Name = "equipmentLabel";
      this.equipmentLabel.Size = new System.Drawing.Size(79, 17);
      this.equipmentLabel.TabIndex = 9;
      this.equipmentLabel.Text = "Equipment:";
      this.equipmentLabel.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // cancelMeetingButton
      // 
      this.cancelMeetingButton.Location = new System.Drawing.Point(324, 335);
      this.cancelMeetingButton.Name = "cancelMeetingButton";
      this.cancelMeetingButton.Size = new System.Drawing.Size(133, 48);
      this.cancelMeetingButton.TabIndex = 11;
      this.cancelMeetingButton.Text = "Cancel";
      this.cancelMeetingButton.UseVisualStyleBackColor = true;
      this.cancelMeetingButton.Click += new System.EventHandler(this.cancelMeetingButton_Click);
      // 
      // RequestMeeting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 414);
      this.Controls.Add(this.cancelMeetingButton);
      this.Controls.Add(this.equipmentList);
      this.Controls.Add(this.equipmentLabel);
      this.Controls.Add(this.submitMeetingButton);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.descriptionLabel);
      this.Controls.Add(this.newMeetingLabel);
      this.Controls.Add(this.guestList);
      this.Controls.Add(this.inviteGuests);
      this.Controls.Add(this.dateLabel);
      this.Controls.Add(this.datePicker);
      this.Name = "RequestMeeting";
      this.Text = "RequestMeeting";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DateTimePicker datePicker;
    private System.Windows.Forms.Label dateLabel;
    private System.Windows.Forms.Label inviteGuests;
    private System.Windows.Forms.CheckedListBox guestList;
    private System.Windows.Forms.Label newMeetingLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button submitMeetingButton;
    private System.Windows.Forms.CheckedListBox equipmentList;
    private System.Windows.Forms.Label equipmentLabel;
    private System.Windows.Forms.Button cancelMeetingButton;
  }
}