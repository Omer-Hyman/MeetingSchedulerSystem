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
      this.userSelectLabel = new System.Windows.Forms.Label();
      this.personaList = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // userSelectLabel
      // 
      this.userSelectLabel.AutoSize = true;
      this.userSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
      this.userSelectLabel.Location = new System.Drawing.Point(22, 33);
      this.userSelectLabel.Name = "userSelectLabel";
      this.userSelectLabel.Size = new System.Drawing.Size(266, 31);
      this.userSelectLabel.TabIndex = 5;
      this.userSelectLabel.Text = "Please select a user.";
      this.userSelectLabel.Click += new System.EventHandler(this.userSelectLabel_Click);
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
      this.personaList.Location = new System.Drawing.Point(76, 96);
      this.personaList.Name = "personaList";
      this.personaList.Size = new System.Drawing.Size(152, 24);
      this.personaList.TabIndex = 6;
      this.personaList.SelectedIndexChanged += new System.EventHandler(this.personaList_SelectedIndexChanged);
      // 
      // PersonaSelect
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 167);
      this.Controls.Add(this.personaList);
      this.Controls.Add(this.userSelectLabel);
      this.Name = "PersonaSelect";
      this.Text = "Select User";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label userSelectLabel;
    private System.Windows.Forms.ComboBox personaList;
  }
}