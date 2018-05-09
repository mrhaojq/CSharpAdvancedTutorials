using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Variance
{
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string ToString()
        {
            return $"Width:{Width},Height:{Height}";
        }
    }
}
