namespace MeetingSchedularSystem
{
  partial class newPSet
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
      this.endDateLabel = new System.Windows.Forms.Label();
      this.startDateLabel = new System.Windows.Forms.Label();
      this.PSetLabel = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.datePicker = new System.Windows.Forms.DateTimePicker();
      this.doneButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // endDateLabel
      // 
      this.endDateLabel.AutoSize = true;
      this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.endDateLabel.Location = new System.Drawing.Point(163, 122);
      this.endDateLabel.Name = "endDateLabel";
      this.endDateLabel.Size = new System.Drawing.Size(92, 18);
      this.endDateLabel.TabIndex = 30;
      this.endDateLabel.Text = "Ending Date:";
      // 
      // startDateLabel
      // 
      this.startDateLabel.AutoSize = true;
      this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.startDateLabel.Location = new System.Drawing.Point(158, 76);
      this.startDateLabel.Name = "startDateLabel";
      this.startDateLabel.Size = new System.Drawing.Size(97, 18);
      this.startDateLabel.TabIndex = 29;
      this.startDateLabel.Text = "Starting Date:";
      // 
      // PSetLabel
      // 
      this.PSetLabel.AutoSize = true;
      this.PSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PSetLabel.Location = new System.Drawing.Point(23, 22);
      this.PSetLabel.Name = "PSetLabel";
      this.PSetLabel.Size = new System.Drawing.Size(421, 25);
      this.PSetLabel.TabIndex = 28;
      this.PSetLabel.Text = "Please input date range for your preference set.";
      this.PSetLabel.Click += new System.EventHandler(this.PSetLabel_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.AllowDrop = true;
      this.dateTimePicker1.CustomFormat = "";
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(284, 122);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
      this.dateTimePicker1.TabIndex = 27;
      // 
      // datePicker
      // 
      this.datePicker.AllowDrop = true;
      this.datePicker.CustomFormat = "";
      this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.datePicker.Location = new System.Drawing.Point(284, 72);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(189, 22);
      this.datePicker.TabIndex = 26;
      // 
      // doneButton
      // 
      this.doneButton.Location = new System.Drawing.Point(298, 165);
      this.doneButton.Name = "doneButton";
      this.doneButton.Size = new System.Drawing.Size(90, 37);
      this.doneButton.TabIndex = 31;
      this.doneButton.Text = "Done";
      this.doneButton.UseVisualStyleBackColor = true;
      this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
      // 
      // newPSet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(720, 237);
      this.Controls.Add(this.doneButton);
      this.Controls.Add(this.endDateLabel);
      this.Controls.Add(this.startDateLabel);
      this.Controls.Add(this.PSetLabel);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.datePicker);
      this.Name = "newPSet";
      this.Text = "New Preference Set";
      this.Load += new System.EventHandler(this.newPSet_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label endDateLabel;
    private System.Windows.Forms.Label startDateLabel;
    private System.Windows.Forms.Label PSetLabel;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker datePicker;
    private System.Windows.Forms.Button doneButton;
  }
}