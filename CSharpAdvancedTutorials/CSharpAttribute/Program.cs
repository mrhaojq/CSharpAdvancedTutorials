using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAttribute
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //测试Conditional特性
            //https://www.runoob.com/csharp/csharp-attribute.html
            //https://blog.csdn.net/fdyshlk/article/details/77603287
            MyClass.Message("In Main Function");
            Function1();

            //obsolete特性测试
            //编译前就可以看到提示
            //MyClass.OldMethod();
            Console.ReadKey();
        }

        static void Function1()
        {
            MyClass.Message("In Function 1.");
            Function2();
        }

        static void Function2()
        {
            MyClass.Message("In Function 2.");
        }
    
    }
}
