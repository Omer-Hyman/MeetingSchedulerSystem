namespace MeetingSchedularSystem
{
  partial class mainUI
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
      this.newMeeting = new System.Windows.Forms.Button();
      this.pendingMeetingsList = new System.Windows.Forms.TableLayoutPanel();
      this.pendingMeetingPlaceholder = new System.Windows.Forms.Label();
      this.pendingMeetings = new System.Windows.Forms.Label();
      this.scheduledMeetings = new System.Windows.Forms.Label();
      this.scheduledMeetingsList = new System.Windows.Forms.TableLayoutPanel();
      this.scheduledMeetingPlaceholder = new System.Windows.Forms.Label();
      this.meetingHistory = new System.Windows.Forms.Button();
      this.userName = new System.Windows.Forms.Label();
      this.switchUser = new System.Windows.Forms.Button();
      this.pendingMeetingsList.SuspendLayout();
      this.scheduledMeetingsList.SuspendLayout();
      this.SuspendLayout();
      // 
      // newMeeting
      // 
      this.newMeeting.Location = new System.Drawing.Point(51, 108);
      this.newMeeting.Name = "newMeeting";
      this.newMeeting.Size = new System.Drawing.Size(167, 51);
      this.newMeeting.TabIndex = 0;
      this.newMeeting.Text = "New Meeting";
      this.newMeeting.UseVisualStyleBackColor = true;
      this.newMeeting.Click += new System.EventHandler(this.button1_Click);
      // 
      // pendingMeetingsList
      // 
      this.pendingMeetingsList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.pendingMeetingsList.ColumnCount = 1;
      this.pendingMeetingsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.pendingMeetingsList.Controls.Add(this.pendingMeetingPlaceholder, 0, 0);
      this.pendingMeetingsList.Location = new System.Drawing.Point(51, 211);
      this.pendingMeetingsList.Name = "pendingMeetingsList";
      this.pendingMeetingsList.RowCount = 1;
      this.pendingMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.pendingMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
      this.pendingMeetingsList.Size = new System.Drawing.Size(425, 159);
      this.pendingMeetingsList.TabIndex = 8;
      this.pendingMeetingsList.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
      // 
      // pendingMeetingPlaceholder
      // 
      this.pendingMeetingPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pendingMeetingPlaceholder.AutoSize = true;
      this.pendingMeetingPlaceholder.Location = new System.Drawing.Point(5, 2);
      this.pendingMeetingPlaceholder.Name = "pendingMeetingPlaceholder";
      this.pendingMeetingPlaceholder.Size = new System.Drawing.Size(415, 155);
      this.pendingMeetingPlaceholder.TabIndex = 0;
      this.pendingMeetingPlaceholder.Text = "Meeting";
      this.pendingMeetingPlaceholder.Click += new System.EventHandler(this.pendingMeetingItem_Click);
      // 
      // pendingMeetings
      // 
      this.pendingMeetings.AutoSize = true;
      this.pendingMeetings.Location = new System.Drawing.Point(48, 173);
      this.pendingMeetings.Name = "pendingMeetings";
      this.pendingMeetings.Size = new System.Drawing.Size(125, 17);
      this.pendingMeetings.TabIndex = 9;
      this.pendingMeetings.Text = "Pending Meetings:";
      this.pendingMeetings.Click += new System.EventHandler(this.label1_Click);
      // 
      // scheduledMeetings
      // 
      this.scheduledMeetings.AutoSize = true;
      this.scheduledMeetings.Location = new System.Drawing.Point(522, 34);
      this.scheduledMeetings.Name = "scheduledMeetings";
      this.scheduledMeetings.Size = new System.Drawing.Size(140, 17);
      this.scheduledMeetings.TabIndex = 10;
      this.scheduledMeetings.Text = "Scheduled Meetings:";
      // 
      // scheduledMeetingsList
      // 
      this.scheduledMeetingsList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.scheduledMeetingsList.ColumnCount = 1;
      this.scheduledMeetingsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.scheduledMeetingsList.Controls.Add(this.scheduledMeetingPlaceholder, 0, 0);
      this.scheduledMeetingsList.Location = new System.Drawing.Point(525, 72);
      this.scheduledMeetingsList.Name = "scheduledMeetingsList";
      this.scheduledMeetingsList.RowCount = 1;
      this.scheduledMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.scheduledMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
      this.scheduledMeetingsList.Size = new System.Drawing.Size(225, 298);
      this.scheduledMeetingsList.TabIndex = 11;
      // 
      // scheduledMeetingPlaceholder
      // 
      this.scheduledMeetingPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scheduledMeetingPlaceholder.AutoSize = true;
      this.scheduledMeetingPlaceholder.Location = new System.Drawing.Point(5, 2);
      this.scheduledMeetingPlaceholder.Name = "scheduledMeetingPlaceholder";
      this.scheduledMeetingPlaceholder.Size = new System.Drawing.Size(215, 294);
      this.scheduledMeetingPlaceholder.TabIndex = 0;
      this.scheduledMeetingPlaceholder.Text = "Meeting";
      // 
      // meetingHistory
      // 
      this.meetingHistory.Location = new System.Drawing.Point(322, 108);
      this.meetingHistory.Name = "meetingHistory";
      this.meetingHistory.Size = new System.Drawing.Size(154, 51);
      this.meetingHistory.TabIndex = 12;
      this.meetingHistory.Text = "Meeting History";
      this.meetingHistory.UseVisualStyleBackColor = true;
      // 
      // userName
      // 
      this.userName.AutoSize = true;
      this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userName.Location = new System.Drawing.Point(45, 33);
      this.userName.Name = "userName";
      this.userName.Size = new System.Drawing.Size(115, 36);
      this.userName.TabIndex = 14;
      this.userName.Text = "Hello ...";
      // 
      // switchUser
      // 
      this.switchUser.Location = new System.Drawing.Point(322, 39);
      this.switchUser.Name = "switchUser";
      this.switchUser.Size = new System.Drawing.Size(154, 37);
      this.switchUser.TabIndex = 15;
      this.switchUser.Text = "Not you? switch user";
      this.switchUser.UseVisualStyleBackColor = true;
      // 
      // mainUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 461);
      this.Controls.Add(this.switchUser);
      this.Controls.Add(this.userName);
      this.Controls.Add(this.meetingHistory);
      this.Controls.Add(this.scheduledMeetingsList);
      this.Controls.Add(this.scheduledMeetings);
      this.Controls.Add(this.pendingMeetings);
      this.Controls.Add(this.pendingMeetingsList);
      this.Controls.Add(this.newMeeting);
      this.Name = "mainUI";
      this.Text = "Meetings Schedular System";
      this.Load += new System.EventHandler(this.mainUI_Load);
      this.pendingMeetingsList.ResumeLayout(false);
      this.pendingMeetingsList.PerformLayout();
      this.scheduledMeetingsList.ResumeLayout(false);
      this.scheduledMeetingsList.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button newMeeting;
    private System.Windows.Forms.TableLayoutPanel pendingMeetingsList;
    private System.Windows.Forms.Label pendingMeetingPlaceholder;
    private System.Windows.Forms.Label pendingMeetings;
    private System.Windows.Forms.Label scheduledMeetings;
    private System.Windows.Forms.TableLayoutPanel scheduledMeetingsList;
    private System.Windows.Forms.Label scheduledMeetingPlaceholder;
    private System.Windows.Forms.Button meetingHistory;
    private System.Windows.Forms.Label userName;
    private System.Windows.Forms.Button switchUser;
  }
}

