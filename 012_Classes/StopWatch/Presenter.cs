using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
   class Presenter
   {
      private Model model;
      private Form1 view;

      public Presenter(Form1 form)
      {
         model = new Model();
         view = form;
         view.Start += ViewStart;
         view.Stop += ViewStop;
         view.Reset += ViewReset;
         view.timer1.Tick += TimerTick;
         view.timer1.Start();
         view.timer1.Enabled = false;
      }

      private void TimerTick(object sender, EventArgs e)
      {
         view.TextBox.Text = model.Tick();
      }

      private void ViewReset(object sender, EventArgs e)
      {
         view.timer1.Stop();
         view.TextBox.Clear();
         model.Reset();
      }

      private void ViewStop(object sender, EventArgs e)
      {
         view.timer1.Enabled = false;
      }

      private void ViewStart(object sender, EventArgs e)
      {
         view.timer1.Enabled = true;
      }
   }
}
