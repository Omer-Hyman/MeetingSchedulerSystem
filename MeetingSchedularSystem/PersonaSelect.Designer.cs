namespace MeetingSchedularSystem
{
  partial class PersonaSelect
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
      this.user1 = new System.Windows.Forms.Button();
      this.user2 = new System.Windows.Forms.Button();
      this.user3 = new System.Windows.Forms.Button();
      this.user4 = new System.Windows.Forms.Button();
      this.user5 = new System.Windows.Forms.Button();
      this.userSelectLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // user1
      // 
      this.user1.Location = new System.Drawing.Point(84, 92);
      this.user1.Name = "user1";
      this.user1.Size = new System.Drawing.Size(140, 40);
      this.user1.TabIndex = 0;
      this.user1.Text = "Mehmet Ozcan";
      this.user1.UseVisualStyleBackColor = true;
      this.user1.Click += new System.EventHandler(this.user1_Click);
      // 
      // user2
      // 
      this.user2.Location = new System.Drawing.Point(84, 242);
      this.user2.Name = "user2";
      this.user2.Size = new System.Drawing.Size(140, 40);
      this.user2.TabIndex = 1;
      this.user2.Text = "Sam Scott";
      this.user2.UseVisualStyleBackColor = true;
      this.user2.Click += new System.EventHandler(this.user2_Click);
      // 
      // user3
      // 
      this.user3.Location = new System.Drawing.Point(84, 142);
      this.user3.Name = "user3";
      this.user3.Size = new System.Drawing.Size(140, 40);
      this.user3.TabIndex = 2;
      this.user3.Text = "Heather McLean";
      this.user3.UseVisualStyleBackColor = true;
      this.user3.Click += new System.EventHandler(this.user3_Click);
      // 
      // user4
      // 
      this.user4.Location = new System.Drawing.Point(84, 192);
      this.user4.Name = "user4";
      this.user4.Size = new System.Drawing.Size(140, 40);
      this.user4.TabIndex = 3;
      this.user4.Text = "Liam Williams";
      this.user4.UseVisualStyleBackColor = true;
      this.user4.Click += new System.EventHandler(this.user4_Click);
      // 
      // user5
      // 
      this.user5.Location = new System.Drawing.Point(84, 292);
      this.user5.Name = "user5";
      this.user5.Size = new System.Drawing.Size(140, 40);
      this.user5.TabIndex = 4;
      this.user5.Text = "Rosalia Cortez";
      this.user5.UseVisualStyleBackColor = true;
      this.user5.Click += new System.EventHandler(this.user5_Click);
      // 
      // userSelectLabel
      // 
      this.userSelectLabel.AutoSize = true;
      this.userSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.userSelectLabel.Location = new System.Drawing.Point(29, 34);
      this.userSelectLabel.Name = "userSelectLabel";
      this.userSelectLabel.Size = new System.Drawing.Size(266, 31);
      this.userSelectLabel.TabIndex = 5;
      this.userSelectLabel.Text = "Please select a user.";
      // 
      // PersonaSelect
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(320, 384);
      this.Controls.Add(this.userSelectLabel);
      this.Controls.Add(this.user5);
      this.Controls.Add(this.user4);
      this.Controls.Add(this.user3);
      this.Controls.Add(this.user2);
      this.Controls.Add(this.user1);
      this.Name = "PersonaSelect";
      this.Text = "PersonaSelect";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button user2;
    private System.Windows.Forms.Button user3;
    private System.Windows.Forms.Button user4;
    private System.Windows.Forms.Button user5;
    private System.Windows.Forms.Label userSelectLabel;
    public System.Windows.Forms.Button user1;
  }
}