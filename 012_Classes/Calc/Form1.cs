using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         new Presenter(this);
      }

      private EventHandler plus;
      private EventHandler minus;
      private EventHandler times;
      private EventHandler division;
      private EventHandler clean;

      public event EventHandler Plus
      {
         add { plus += value; }
         remove { plus -= value; }
      }

      public event EventHandler Minus
      {
         add { minus += value; }
         remove { minus -= value; }
      }

      public event EventHandler Times
      {
         add { times += value; }
         remove { times -= value; }
      }

      public event EventHandler Division
      {
         add { division += value; }
         remove { division -= value; }
      }

      public event EventHandler Clean
      {
         add { clean += value; }
         remove { clean -= value; }
      }

      private void ButtonPlus_Click(object sender, EventArgs e)
      {
         plus.Invoke(sender, e);
      }

      private void ButtonMinus_Click(object sender, EventArgs e)
      {
         minus.Invoke(sender, e);
      }

      private void ButtonTimes_Click(object sender, EventArgs e)
      {
         times.Invoke(sender, e);
      }

      private void ButtonDivision_Click(object sender, EventArgs e)
      {
         division.Invoke(sender, e);
      }

      private void ButtonClean_Click(object sender, EventArgs e)
      {
         clean.Invoke(sender, e);
      }
   }
}
