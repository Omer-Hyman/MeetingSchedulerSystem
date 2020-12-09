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
      Initiator Initiator = new Initiator(personaList.SelectedItem.ToString());
      Form main = new mainPage(Initiator);
      this.Hide();
      main.Show();

/*      //This only for persona/meeting initiator initialisation
      switch (this.Text)
      {
        case "Liam Williams":

          // persona instance 1: Liam
          Personas persona1 = new Personas("Liam Williams", 5, true);
          try
          {
            this.fillPersonaSet(persona1, "preference", this.liam_preferenceSet.Text);
          }
          catch (MSlotException ex)
          {
            check = false;
            TextBox liamResult = this.liamResult;
            liamResult.Text = liamResult.Text + ex.Message + "\n";
          }
          break;
        case "Sam Scott":

          break;
        case "Rosalia Cortez":

          break;
        case "Heather McLean":

          break;
      }*/
    }

    private void userSelectLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
