namespace MeetingSchedularSystem
{
  partial class newESet
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
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.datePicker = new System.Windows.Forms.DateTimePicker();
      this.ESetLabel = new System.Windows.Forms.Label();
      this.startDateLabel = new System.Windows.Forms.Label();
      this.endDateLabel = new System.Windows.Forms.Label();
      this.doneButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.AllowDrop = true;
      this.dateTimePicker1.CustomFormat = "";
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(284, 126);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
      this.dateTimePicker1.TabIndex = 22;
      // 
      // datePicker
      // 
      this.datePicker.AllowDrop = true;
      this.datePicker.CustomFormat = "";
      this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.datePicker.Location = new System.Drawing.Point(284, 77);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(189, 22);
      this.datePicker.TabIndex = 21;
      // 
      // ESetLabel
      // 
      this.ESetLabel.AutoSize = true;
      this.ESetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ESetLabel.Location = new System.Drawing.Point(24, 29);
      this.ESetLabel.Name = "ESetLabel";
      this.ESetLabel.Size = new System.Drawing.Size(510, 31);
      this.ESetLabel.TabIndex = 23;
      this.ESetLabel.Text = "please input date range for your exclusion set.";
      // 
      // startDateLabel
      // 
      this.startDateLabel.AutoSize = true;
      this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.startDateLabel.Location = new System.Drawing.Point(166, 80);
      this.startDateLabel.Name = "startDateLabel";
      this.startDateLabel.Size = new System.Drawing.Size(97, 18);
      this.startDateLabel.TabIndex = 24;
      this.startDateLabel.Text = "Starting Date:";
      // 
      // endDateLabel
      // 
      this.endDateLabel.AutoSize = true;
      this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.endDateLabel.Location = new System.Drawing.Point(171, 126);
      this.endDateLabel.Name = "endDateLabel";
      this.endDateLabel.Size = new System.Drawing.Size(92, 18);
      this.endDateLabel.TabIndex = 25;
      this.endDateLabel.Text = "Ending Date:";
      // 
      // doneButton
      // 
      this.doneButton.Location = new System.Drawing.Point(284, 168);
      this.doneButton.Name = "doneButton";
      this.doneButton.Size = new System.Drawing.Size(87, 35);
      this.doneButton.TabIndex = 26;
      this.doneButton.Text = "Done";
      this.doneButton.UseVisualStyleBackColor = true;
      this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
      // 
      // newESet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(901, 297);
      this.Controls.Add(this.doneButton);
      this.Controls.Add(this.endDateLabel);
      this.Controls.Add(this.startDateLabel);
      this.Controls.Add(this.ESetLabel);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.datePicker);
      this.Name = "newESet";
      this.Text = "newESet";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker datePicker;
    private System.Windows.Forms.Label ESetLabel;
    private System.Windows.Forms.Label startDateLabel;
    private System.Windows.Forms.Label endDateLabel;
    private System.Windows.Forms.Button doneButton;
  }
}