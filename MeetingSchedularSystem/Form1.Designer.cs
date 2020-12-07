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
            this.historyButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.switchUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pendingMeetingsList.SuspendLayout();
            this.scheduledMeetingsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMeeting
            // 
            this.newMeeting.Location = new System.Drawing.Point(76, 169);
            this.newMeeting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newMeeting.Name = "newMeeting";
            this.newMeeting.Size = new System.Drawing.Size(250, 80);
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
            this.pendingMeetingsList.Location = new System.Drawing.Point(76, 330);
            this.pendingMeetingsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendingMeetingsList.Name = "pendingMeetingsList";
            this.pendingMeetingsList.RowCount = 1;
            this.pendingMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pendingMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.pendingMeetingsList.Size = new System.Drawing.Size(638, 248);
            this.pendingMeetingsList.TabIndex = 8;
            this.pendingMeetingsList.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pendingMeetingPlaceholder
            // 
            this.pendingMeetingPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingMeetingPlaceholder.AutoSize = true;
            this.pendingMeetingPlaceholder.Location = new System.Drawing.Point(6, 2);
            this.pendingMeetingPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pendingMeetingPlaceholder.Name = "pendingMeetingPlaceholder";
            this.pendingMeetingPlaceholder.Size = new System.Drawing.Size(626, 244);
            this.pendingMeetingPlaceholder.TabIndex = 0;
            this.pendingMeetingPlaceholder.Text = "Meeting";
            this.pendingMeetingPlaceholder.Click += new System.EventHandler(this.pendingMeetingItem_Click);
            // 
            // pendingMeetings
            // 
            this.pendingMeetings.AutoSize = true;
            this.pendingMeetings.Location = new System.Drawing.Point(72, 270);
            this.pendingMeetings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pendingMeetings.Name = "pendingMeetings";
            this.pendingMeetings.Size = new System.Drawing.Size(191, 25);
            this.pendingMeetings.TabIndex = 9;
            this.pendingMeetings.Text = "Pending Meetings:";
            this.pendingMeetings.Click += new System.EventHandler(this.label1_Click);
            // 
            // scheduledMeetings
            // 
            this.scheduledMeetings.AutoSize = true;
            this.scheduledMeetings.Location = new System.Drawing.Point(783, 53);
            this.scheduledMeetings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scheduledMeetings.Name = "scheduledMeetings";
            this.scheduledMeetings.Size = new System.Drawing.Size(214, 25);
            this.scheduledMeetings.TabIndex = 10;
            this.scheduledMeetings.Text = "Scheduled Meetings:";
            // 
            // scheduledMeetingsList
            // 
            this.scheduledMeetingsList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.scheduledMeetingsList.ColumnCount = 1;
            this.scheduledMeetingsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scheduledMeetingsList.Controls.Add(this.scheduledMeetingPlaceholder, 0, 0);
            this.scheduledMeetingsList.Location = new System.Drawing.Point(788, 112);
            this.scheduledMeetingsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduledMeetingsList.Name = "scheduledMeetingsList";
            this.scheduledMeetingsList.RowCount = 1;
            this.scheduledMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scheduledMeetingsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.scheduledMeetingsList.Size = new System.Drawing.Size(338, 466);
            this.scheduledMeetingsList.TabIndex = 11;
            // 
            // scheduledMeetingPlaceholder
            // 
            this.scheduledMeetingPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduledMeetingPlaceholder.AutoSize = true;
            this.scheduledMeetingPlaceholder.Location = new System.Drawing.Point(6, 2);
            this.scheduledMeetingPlaceholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scheduledMeetingPlaceholder.Name = "scheduledMeetingPlaceholder";
            this.scheduledMeetingPlaceholder.Size = new System.Drawing.Size(326, 462);
            this.scheduledMeetingPlaceholder.TabIndex = 0;
            this.scheduledMeetingPlaceholder.Text = "Meeting";
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(483, 169);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(231, 80);
            this.historyButton.TabIndex = 12;
            this.historyButton.Text = "Meeting History";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(68, 52);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(185, 55);
            this.userName.TabIndex = 14;
            this.userName.Text = "Hello ...";
            // 
            // switchUser
            // 
            this.switchUser.Location = new System.Drawing.Point(483, 61);
            this.switchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switchUser.Name = "switchUser";
            this.switchUser.Size = new System.Drawing.Size(231, 58);
            this.switchUser.TabIndex = 15;
            this.switchUser.Text = "Not you? switch user";
            this.switchUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1050, 91);
            this.button1.TabIndex = 16;
            this.button1.Text = "show all pending and scheduled meetings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.switchUser);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.scheduledMeetingsList);
            this.Controls.Add(this.scheduledMeetings);
            this.Controls.Add(this.pendingMeetings);
            this.Controls.Add(this.pendingMeetingsList);
            this.Controls.Add(this.newMeeting);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    private System.Windows.Forms.Button historyButton;
    private System.Windows.Forms.Label userName;
    private System.Windows.Forms.Button switchUser;
        private System.Windows.Forms.Button button1;
    }
}

