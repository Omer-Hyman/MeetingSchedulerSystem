namespace MeetingSchedularSystem
{
  partial class mainPage
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
      System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
      this.viewSets = new System.Windows.Forms.Button();
      this.newMeeting = new System.Windows.Forms.Button();
      this.meetingHistory = new System.Windows.Forms.Button();
      this.helloUser = new System.Windows.Forms.Label();
      this.switchUser = new System.Windows.Forms.Button();
      this.listView2 = new System.Windows.Forms.ListView();
      this.listView1 = new System.Windows.Forms.ListView();
      this.pendingMeetingsLabel = new System.Windows.Forms.Label();
      this.scheduledMeetingsLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // viewSets
      // 
      this.viewSets.Location = new System.Drawing.Point(28, 205);
      this.viewSets.Name = "viewSets";
      this.viewSets.Size = new System.Drawing.Size(339, 57);
      this.viewSets.TabIndex = 1;
      this.viewSets.Text = "View Preferance and Exclusion sets";
      this.viewSets.UseVisualStyleBackColor = true;
      this.viewSets.Click += new System.EventHandler(this.viewSets_Click);
      // 
      // newMeeting
      // 
      this.newMeeting.Location = new System.Drawing.Point(28, 136);
      this.newMeeting.Name = "newMeeting";
      this.newMeeting.Size = new System.Drawing.Size(145, 51);
      this.newMeeting.TabIndex = 2;
      this.newMeeting.Text = "New Meeting";
      this.newMeeting.UseVisualStyleBackColor = true;
      this.newMeeting.Click += new System.EventHandler(this.newMeeting_Click);
      // 
      // meetingHistory
      // 
      this.meetingHistory.Location = new System.Drawing.Point(207, 136);
      this.meetingHistory.Name = "meetingHistory";
      this.meetingHistory.Size = new System.Drawing.Size(160, 51);
      this.meetingHistory.TabIndex = 3;
      this.meetingHistory.Text = "Meeting History";
      this.meetingHistory.UseVisualStyleBackColor = true;
      this.meetingHistory.Click += new System.EventHandler(this.meetingHistory_Click);
      // 
      // helloUser
      // 
      this.helloUser.AutoSize = true;
      this.helloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.helloUser.Location = new System.Drawing.Point(22, 76);
      this.helloUser.Name = "helloUser";
      this.helloUser.Size = new System.Drawing.Size(140, 32);
      this.helloUser.TabIndex = 4;
      this.helloUser.Text = "Welcome ";
      this.helloUser.Click += new System.EventHandler(this.helloUser_Click);
      // 
      // switchUser
      // 
      this.switchUser.Location = new System.Drawing.Point(208, 12);
      this.switchUser.Name = "switchUser";
      this.switchUser.Size = new System.Drawing.Size(185, 51);
      this.switchUser.TabIndex = 5;
      this.switchUser.Text = "Not You? Switch User";
      this.switchUser.UseVisualStyleBackColor = true;
      this.switchUser.Click += new System.EventHandler(this.switchUser_Click);
      // 
      // listView2
      // 
      this.listView2.HideSelection = false;
      this.listView2.Location = new System.Drawing.Point(207, 310);
      this.listView2.Margin = new System.Windows.Forms.Padding(2);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(161, 197);
      this.listView2.TabIndex = 9;
      this.listView2.UseCompatibleStateImageBehavior = false;
      // 
      // listView1
      // 
      listViewGroup4.Header = "ListViewGroup";
      listViewGroup4.Name = "Ya";
      this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
      this.listView1.HideSelection = false;
      this.listView1.Location = new System.Drawing.Point(28, 310);
      this.listView1.Margin = new System.Windows.Forms.Padding(2);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(161, 197);
      this.listView1.TabIndex = 8;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // pendingMeetingsLabel
      // 
      this.pendingMeetingsLabel.AutoSize = true;
      this.pendingMeetingsLabel.Location = new System.Drawing.Point(25, 278);
      this.pendingMeetingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.pendingMeetingsLabel.Name = "pendingMeetingsLabel";
      this.pendingMeetingsLabel.Size = new System.Drawing.Size(125, 17);
      this.pendingMeetingsLabel.TabIndex = 7;
      this.pendingMeetingsLabel.Text = "Pending Meetings:";
      // 
      // scheduledMeetingsLabel
      // 
      this.scheduledMeetingsLabel.AutoSize = true;
      this.scheduledMeetingsLabel.Location = new System.Drawing.Point(204, 278);
      this.scheduledMeetingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.scheduledMeetingsLabel.Name = "scheduledMeetingsLabel";
      this.scheduledMeetingsLabel.Size = new System.Drawing.Size(140, 17);
      this.scheduledMeetingsLabel.TabIndex = 6;
      this.scheduledMeetingsLabel.Text = "Scheduled Meetings:";
      // 
      // mainPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 543);
      this.Controls.Add(this.listView2);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.pendingMeetingsLabel);
      this.Controls.Add(this.scheduledMeetingsLabel);
      this.Controls.Add(this.switchUser);
      this.Controls.Add(this.helloUser);
      this.Controls.Add(this.meetingHistory);
      this.Controls.Add(this.newMeeting);
      this.Controls.Add(this.viewSets);
      this.Name = "mainPage";
      this.Text = "mainPage";
      this.Load += new System.EventHandler(this.mainPage_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button viewSets;
    private System.Windows.Forms.Button meetingHistory;
    private System.Windows.Forms.Label helloUser;
    private System.Windows.Forms.Button switchUser;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label pendingMeetingsLabel;
    private System.Windows.Forms.Label scheduledMeetingsLabel;
    public System.Windows.Forms.Button newMeeting;
  }
}