using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  public partial class newPSet : Form
  {
    public newPSet(string persona)
    {
      InitializeComponent();
      PSetLabel.Text = persona + ", " + PSetLabel.Text;
    }

    private void PSetLabel_Click(object sender, EventArgs e)
    {

    }

    private void newPSet_Load(object sender, EventArgs e)
    {

    }

    private void doneButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
