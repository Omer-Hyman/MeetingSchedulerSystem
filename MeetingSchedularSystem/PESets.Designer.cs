namespace MeetingSchedularSystem
{
  partial class PESets
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
      this.liam_preferenceSet = new System.Windows.Forms.TextBox();
      this.sam_preferenceSet = new System.Windows.Forms.TextBox();
      this.newPSet = new System.Windows.Forms.Button();
      this.newESet = new System.Windows.Forms.Button();
      this.personaList = new System.Windows.Forms.ComboBox();
      this.userSelectLabel = new System.Windows.Forms.Label();
      this.pSetLabel = new System.Windows.Forms.Label();
      this.eSetLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // liam_preferenceSet
      // 
      this.liam_preferenceSet.Location = new System.Drawing.Point(61, 184);
      this.liam_preferenceSet.Margin = new System.Windows.Forms.Padding(4);
      this.liam_preferenceSet.Multiline = true;
      this.liam_preferenceSet.Name = "liam_preferenceSet";
      this.liam_preferenceSet.Size = new System.Drawing.Size(222, 156);
      this.liam_preferenceSet.TabIndex = 9;
      this.liam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // sam_preferenceSet
      // 
      this.sam_preferenceSet.Location = new System.Drawing.Point(291, 184);
      this.sam_preferenceSet.Margin = new System.Windows.Forms.Padding(4);
      this.sam_preferenceSet.Multiline = true;
      this.sam_preferenceSet.Name = "sam_preferenceSet";
      this.sam_preferenceSet.Size = new System.Drawing.Size(250, 156);
      this.sam_preferenceSet.TabIndex = 14;
      this.sam_preferenceSet.Text = "10/12/2018 Slot 1\r\n10/12/2018 Slot 2";
      // 
      // newPSet
      // 
      this.newPSet.Location = new System.Drawing.Point(224, 84);
      this.newPSet.Name = "newPSet";
      this.newPSet.Size = new System.Drawing.Size(131, 46);
      this.newPSet.TabIndex = 17;
      this.newPSet.Text = "Add New Preference Set";
      this.newPSet.UseVisualStyleBackColor = true;
      this.newPSet.Click += new System.EventHandler(this.newPSet_Click);
      // 
      // newESet
      // 
      this.newESet.Location = new System.Drawing.Point(395, 84);
      this.newESet.Name = "newESet";
      this.newESet.Size = new System.Drawing.Size(131, 46);
      this.newESet.TabIndex = 18;
      this.newESet.Text = "Add New Exclusion Set";
      this.newESet.UseVisualStyleBackColor = true;
      this.newESet.Click += new System.EventHandler(this.newESet_Click);
      // 
      // personaList
      // 
      this.personaList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.personaList.FormattingEnabled = true;
      this.personaList.Items.AddRange(new object[] {
            "Liam Williams",
            "Sam Scott",
            "Rosalia Cortez",
            "Heather McLean"});
      this.personaList.Location = new System.Drawing.Point(61, 84);
      this.personaList.Name = "personaList";
      this.personaList.Size = new System.Drawing.Size(121, 24);
      this.personaList.TabIndex = 20;
      // 
      // userSelectLabel
      // 
      this.userSelectLabel.AutoSize = true;
      this.userSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.userSelectLabel.Location = new System.Drawing.Point(34, 23);
      this.userSelectLabel.Name = "userSelectLabel";
      this.userSelectLabel.Size = new System.Drawing.Size(476, 31);
      this.userSelectLabel.TabIndex = 19;
      this.userSelectLabel.Text = "Please select a user to view their sets.";
      this.userSelectLabel.Click += new System.EventHandler(this.userSelectLabel_Click);
      // 
      // pSetLabel
      // 
      this.pSetLabel.AutoSize = true;
      this.pSetLabel.Location = new System.Drawing.Point(58, 154);
      this.pSetLabel.Name = "pSetLabel";
      this.pSetLabel.Size = new System.Drawing.Size(107, 17);
      this.pSetLabel.TabIndex = 21;
      this.pSetLabel.Text = "Preference Set:";
      // 
      // eSetLabel
      // 
      this.eSetLabel.AutoSize = true;
      this.eSetLabel.Location = new System.Drawing.Point(288, 154);
      this.eSetLabel.Name = "eSetLabel";
      this.eSetLabel.Size = new System.Drawing.Size(96, 17);
      this.eSetLabel.TabIndex = 22;
      this.eSetLabel.Text = "Exclusion Set:";
      // 
      // PESets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(577, 407);
      this.Controls.Add(this.eSetLabel);
      this.Controls.Add(this.pSetLabel);
      this.Controls.Add(this.personaList);
      this.Controls.Add(this.userSelectLabel);
      this.Controls.Add(this.newESet);
      this.Controls.Add(this.newPSet);
      this.Controls.Add(this.sam_preferenceSet);
      this.Controls.Add(this.liam_preferenceSet);
      this.Name = "PESets";
      this.Text = "PESets";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox liam_preferenceSet;
    private System.Windows.Forms.TextBox sam_preferenceSet;
    private System.Windows.Forms.Button newPSet;
    private System.Windows.Forms.Button newESet;
    private System.Windows.Forms.ComboBox personaList;
    private System.Windows.Forms.Label userSelectLabel;
    private System.Windows.Forms.Label pSetLabel;
    private System.Windows.Forms.Label eSetLabel;
  }
}