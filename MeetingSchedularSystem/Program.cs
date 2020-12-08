using System;
using System.Windows.Forms;

namespace MeetingSchedularSystem
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]


    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new PersonaSelect());

      Personas mehmet = new Personas("Mehmet Ozcan", 2, false);
      Personas heather = new Personas("Heather McLean", 3, false);
      Personas liam = new Personas("Liam Williams", 1, true);
      Personas sam = new Personas("Sam Scott", 5, false);
      Personas rosalia = new Personas("Rosalia Cortez", 4, false);
    }
  }
}
