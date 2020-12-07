using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
      Application.Run(new mainUI());

      Personas mehmet = new Personas("Mehmet Ozcan", 2);
      Personas heather = new Personas("Heather McLean", 3);
      Personas liam = new Personas("Liam Williams", 1);
      Personas sam = new Personas("Sam Scott", 5);
      Personas rosalia = new Personas("Rosalia Cortez", 4);
    }
  }
}
