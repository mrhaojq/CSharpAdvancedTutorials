#define DEBUG //debug模式 工程中默认会定义DEBUG宏 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpAttribute
{
  public  class MyClass
    {

        //条件编译 
        [Conditional("DEBUG")]//条件特性
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

        //废弃
        [Obsolete("Dot't use OldMethod,use NewMethod instead",true)]
        public static void OldMethod()
        {
            Console.WriteLine("It is the old method.");
        }


        public static void NewMethod()
        {
            Console.WriteLine("It is the new method.");
        }
    }
}
