using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDemo
{
   public class ExampleClass
    {
    //    dynamic 关键字可以直接出现，也可以作为构造类型的组件在下列情况中出现：

    //在声明中，作为属性、字段、索引器、参数、返回值、本地变量或类型约束的类型。 下面的类定义在多个不同的声明中使用 dynamic。
        //A dynamic field.
       static dynamic field;

        //A dynamic property
       public dynamic prop { get; set; }

        //A dynamic return type and a dynamic parameter
        public dynamic exampleMethod(dynamic d)
        {
            //A dynamic local variable
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }

        //在显式类型转换中，作为转换的目标类型。
        static void convertToDynamic()
        {
            dynamic d;
            int i = 20;
            d = (dynamic)i;
            Console.WriteLine(d);

            string s = "Example string";
            d = (dynamic)s;
            Console.WriteLine(d);

            DateTime dt = DateTime.Today;
            d = (dynamic)dt;
            Console.WriteLine(d);
        }
        // Results:
        // 20
        // Example string.
        // 2/17/2009 9:12:00 AM


    }
}
