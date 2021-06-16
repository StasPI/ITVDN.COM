using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   class Block : object
   {
      int top;
      int bottom;
      int left;
      int right;

      public Block(int top, int bottom, int left, int right)
      {
         this.top = top;
         this.bottom = bottom;
         this.left = left;
         this.right = right;
      }

      public override bool Equals(Object obj)
      {
         if (obj == null || this.GetType() != obj.GetType())
            return false;

         Block b = (Block)obj;
         return (top == b.top) && (bottom == b.bottom) && (left == b.left) && (right == b.right);
      }

      public override int GetHashCode()
      {
         return (top ^ bottom) + (left ^ right);
      }

      public override string ToString()
      {
         return $"top: {top}, bottom: {bottom}, left: {left}, right: {right}";
      }
   }
}
