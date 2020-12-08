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
      this.dateEnd = new System.Windows.Forms.TextBox();
      this.dateStart = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // dateEnd
      // 
      this.dateEnd.Location = new System.Drawing.Point(300, 240);
      this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
      this.dateEnd.Name = "dateEnd";
      this.dateEnd.Size = new System.Drawing.Size(200, 22);
      this.dateEnd.TabIndex = 7;
      this.dateEnd.Text = "12/12/2018";
      // 
      // dateStart
      // 
      this.dateStart.Location = new System.Drawing.Point(300, 189);
      this.dateStart.Margin = new System.Windows.Forms.Padding(4);
      this.dateStart.Name = "dateStart";
      this.dateStart.Size = new System.Drawing.Size(200, 22);
      this.dateStart.TabIndex = 6;
      this.dateStart.Text = "10/12/2018";
      // 
      // newESet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dateEnd);
      this.Controls.Add(this.dateStart);
      this.Name = "newESet";
      this.Text = "newESet";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox dateEnd;
    private System.Windows.Forms.TextBox dateStart;
  }
}