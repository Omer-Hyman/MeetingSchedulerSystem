using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingSchedularSystem
{
  class Personas
  {
    private string name;
    private int importanceLevel;
    private bool initiator;

    public Personas(string Name, int Importance, bool initiator)
    {
      name = Name;
      importanceLevel = Importance;
      initiator = Initiator;
    }

    public Personas()
    {
      name = "Fname Lname";
      importanceLevel = 5;
      initiator = false;

    }

    public string Name { get; set; }
    public int Importance { get; set; }
    public bool Initiator { get; set;
    }

    public void toggleInitiator()
    {
      if (initiator)
      {
        initiator = false;
      }
      else
      {
        initiator = true;
      }
    }
    }
  }

