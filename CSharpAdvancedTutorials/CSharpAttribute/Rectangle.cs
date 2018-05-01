using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAttribute
{
    [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
  public  class Rectangle
    {

        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        [DeBugInfo(55,"Zara Ali","19/10/2012",
            Message ="Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DeBugInfo(56,"Zara Ali","19/10/2012")]
        public void Display()
        {
            Console.WriteLine( $"Length:{length}");
            Console.WriteLine($"Width:{width}");
            Console.WriteLine($"Area:{GetArea()}");
        }
    }
}
