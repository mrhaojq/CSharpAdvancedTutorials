using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CSharpExtensionMethod
{
   public static class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myInterface">扩展IMyInterface 接口</param>
        /// <param name="i">添加额外参数</param>
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            WriteLine("Extension.MethodA(this IMyInterface myInterface,int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            WriteLine("Extension.MethodA(this IMyInterface myInterface,string s)");
        }

        public static void MethodB(this IMyInterface myInterface)
        {
            WriteLine("Extension.MethodB(this IMyInterface myInterface)");
        }
    }
}
