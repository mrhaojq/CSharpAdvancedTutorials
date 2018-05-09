using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CSharpGenerics.Variance
{
    public class ShapeDisplay : IDisplay<Shape>
    {
        /// <summary>
        ///只能将具体类的 泛型 Shape 作为参数传递到方法中
        /// </summary>
        /// <param name="item"></param>
        public void Show(Shape item)
        {
            WriteLine($"{item.GetType().Name} Width:{item.Width},Height:{item.Height}");
        }
    }
}
