﻿using System;
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
  public partial class newESet : Form
  {
    public newESet(string persona)
    {
      InitializeComponent();
      ESetLabel.Text = persona + ", " + ESetLabel.Text;

    }

    private void doneButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
