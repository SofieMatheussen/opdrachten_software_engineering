﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
  public partial class TeerlingView : UserControl
  {
    private TeerlingController _controller; //controller ontvangen wanneer view wordt aangemaakt

    public TeerlingView(TeerlingController controller)
    {
      _controller = controller;
      InitializeComponent();
    }
    public TeerlingController getController()
    {
      return _controller;
    }
    private void TeerlingView_Load(object sender, EventArgs e)
    {

    }

    public void updateUI() //updatemethode 
    {
      teerlingLabel.Text = _controller._model.Aantalogen.ToString();
      werpButton.Visible = _controller._model.Werp;
      updateStyles();
    }

    private void werpButton_Click(object sender, EventArgs e)
    {
      _controller.werpTeerling(); //controller teerling laten werpen
      updateUI(); //update label van teerlingen
    }

    private void teerlingLabel_Click(object sender, EventArgs e)
    {
      _controller.toggleVast();
      updateStyles();
    }

   //kleur aanpassen van teerlingen wanneer vast of los staan
    private void updateStyles()
    {
      if (_controller._model.Vast)
      {
        teerlingLabel.BackColor = Color.Red;
      }
      else
      {
        teerlingLabel.BackColor = default(Color);
      }
    }
  }
}
