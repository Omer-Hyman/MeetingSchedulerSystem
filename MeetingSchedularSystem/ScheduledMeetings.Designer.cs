
namespace MeetingSchedularSystem
{
    partial class ScheduledMeetings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listView1 = new System.Windows.Forms.ListView();
      this.listView2 = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(335, 27);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(136, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Scheduled Meetings";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(57, 27);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(121, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Pending Meetings";
      // 
      // listView1
      // 
      this.listView1.HideSelection = false;
      this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
      this.listView1.Location = new System.Drawing.Point(38, 59);
      this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(161, 197);
      this.listView1.TabIndex = 2;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
      // 
      // listView2
      // 
      this.listView2.HideSelection = false;
      this.listView2.Location = new System.Drawing.Point(324, 59);
      this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(161, 197);
      this.listView2.TabIndex = 3;
      this.listView2.UseCompatibleStateImageBehavior = false;
      // 
      // ScheduledMeetings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(533, 288);
      this.Controls.Add(this.listView2);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "ScheduledMeetings";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.ScheduledMeetings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}

