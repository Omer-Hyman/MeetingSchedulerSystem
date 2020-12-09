using System;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  public partial class PersonaSelect : Form
  {
    public PersonaSelect()
    {
      InitializeComponent();

      Personas mehmet = new Personas("Mehmet Ozcan", 2, false);
      Personas heather = new Personas("Heather McLean", 3, false);
      Personas liam = new Personas("Liam Williams", 1, false);
      Personas sam = new Personas("Sam Scott", 5, false);
      Personas rosalia = new Personas("Rosalia Cortez", 4, false);
    }
    public string initiator()
    {
      return this.Text;
    }

    private void personaList_SelectedIndexChanged(object sender, EventArgs e)
    {
      Form main = new mainPage(personaList.SelectedItem.ToString());
      this.Hide();
      main.Show();
    }

    private void userSelectLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
