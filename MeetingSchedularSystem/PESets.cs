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
  public partial class PESets : Form
  {
    public PESets()
    {
      InitializeComponent();
    }

    private void userSelectLabel_Click(object sender, EventArgs e)
    {

    }

    private void newPSet_Click(object sender, EventArgs e)
    {
      Form pSet = new newPSet();
      pSet.Show();
    }

    private void newESet_Click(object sender, EventArgs e)
    {
      Form eSet = new newESet();
      eSet.Show();
    }
  }
}
