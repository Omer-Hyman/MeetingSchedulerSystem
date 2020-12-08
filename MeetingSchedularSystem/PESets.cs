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
      if (personaList.Text == "")
      {
        MessageBox.Show("No user selected", "Please select a user", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      { 
        Form pSet = new newPSet(personaList.Text);
        pSet.Show();
      }
    }

    private void newESet_Click(object sender, EventArgs e)
    {
      if (personaList.Text == "")
      {
        MessageBox.Show("No user selected", "Please select a user", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        Form eSet = new newESet(personaList.Text);
        eSet.Show();
      }
    }

    private void personaList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
