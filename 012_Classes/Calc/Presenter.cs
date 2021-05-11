using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
   class Presenter
   {
      private Model model;
      private Form1 view;
      string result;

      public Presenter(Form1 form)
      {
         model = new Model();
         view = form;
         view.Plus += ViewPlus;
         view.Minus += ViewMinus;
         view.Times += ViewTimes;
         view.Division += ViewDivision;
         view.Clean += ViewClean;

      }
      private void ViewPlus(object sender, EventArgs e)
      {
         result = view.textBoxA.Text;
         view.textBoxResult.Text = model.Plus(Int32.Parse(view.textBoxA.Text), Int32.Parse(view.textBoxB.Text));
      }

      private void ViewMinus(object sender, EventArgs e)
      {
         result = view.textBoxA.Text;
         view.textBoxResult.Text = model.Minus(Int32.Parse(view.textBoxA.Text), Int32.Parse(view.textBoxB.Text));
      }

      private void ViewTimes(object sender, EventArgs e)
      {
         result = view.textBoxA.Text;
         view.textBoxResult.Text = model.Times(Int32.Parse(view.textBoxA.Text), Int32.Parse(view.textBoxB.Text));
      }

      private void ViewDivision(object sender, EventArgs e)
      {
         result = view.textBoxA.Text;
         view.textBoxResult.Text = model.Division(Int32.Parse(view.textBoxA.Text), Int32.Parse(view.textBoxB.Text));
      }

      private void ViewClean(object sender, EventArgs e)
      {
         view.textBoxA.Text = "";
         view.textBoxB.Text = "";
         view.textBoxResult.Text = "";
      }
   }
}
