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
      this.viewSets = new System.Windows.Forms.Button();
      this.newMeeting = new System.Windows.Forms.Button();
      this.meetingHistory = new System.Windows.Forms.Button();
      this.helloUser = new System.Windows.Forms.Label();
      this.switchUser = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // viewSets
      // 
      this.viewSets.Location = new System.Drawing.Point(57, 224);
      this.viewSets.Name = "viewSets";
      this.viewSets.Size = new System.Drawing.Size(193, 78);
      this.viewSets.TabIndex = 1;
      this.viewSets.Text = "View other user\'s Preferance and Exclusion sets";
      this.viewSets.UseVisualStyleBackColor = true;
      this.viewSets.Click += new System.EventHandler(this.viewSets_Click);
      // 
      // newMeeting
      // 
      this.newMeeting.Location = new System.Drawing.Point(57, 119);
      this.newMeeting.Name = "newMeeting";
      this.newMeeting.Size = new System.Drawing.Size(145, 51);
      this.newMeeting.TabIndex = 2;
      this.newMeeting.Text = "New Meeting";
      this.newMeeting.UseVisualStyleBackColor = true;
      this.newMeeting.Click += new System.EventHandler(this.newMeeting_Click);
      // 
      // meetingHistory
      // 
      this.meetingHistory.Location = new System.Drawing.Point(427, 119);
      this.meetingHistory.Name = "meetingHistory";
      this.meetingHistory.Size = new System.Drawing.Size(145, 51);
      this.meetingHistory.TabIndex = 3;
      this.meetingHistory.Text = "Meeting History";
      this.meetingHistory.UseVisualStyleBackColor = true;
      this.meetingHistory.Click += new System.EventHandler(this.meetingHistory_Click);
      // 
      // helloUser
      // 
      this.helloUser.AutoSize = true;
      this.helloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.helloUser.Location = new System.Drawing.Point(63, 35);
      this.helloUser.Name = "helloUser";
      this.helloUser.Size = new System.Drawing.Size(175, 40);
      this.helloUser.TabIndex = 4;
      this.helloUser.Text = "Welcome ";
      this.helloUser.Click += new System.EventHandler(this.helloUser_Click);
      // 
      // switchUser
      // 
      this.switchUser.Location = new System.Drawing.Point(244, 119);
      this.switchUser.Name = "switchUser";
      this.switchUser.Size = new System.Drawing.Size(145, 51);
      this.switchUser.TabIndex = 5;
      this.switchUser.Text = "Switch User";
      this.switchUser.UseVisualStyleBackColor = true;
      this.switchUser.Click += new System.EventHandler(this.switchUser_Click);
      // 
      // mainPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
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
    private System.Windows.Forms.Button newMeeting;
    private System.Windows.Forms.Button meetingHistory;
    private System.Windows.Forms.Label helloUser;
    private System.Windows.Forms.Button switchUser;
  }
}