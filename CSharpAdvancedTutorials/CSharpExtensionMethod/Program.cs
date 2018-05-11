using System;
using static System.Console;
using System.Linq;
using CSharpExtensionMethod.ExtensionMethodsDemo1;

namespace CSharpExtensionMethod
{
    class Program
    {
        //https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        static void Main(string[] args)
        {
            Console.WriteLine("System.Linq 中的扩展方法");
            LinqOrderBy();

            WriteLine("String ExtensionMethod WordCount");
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            WriteLine(i);

            WriteLine("ExtMethodDemo.ExtMethodDemoTest 扩展接口的额外参数传递以及 优先级（覆盖规则）");
            ExtMethodDemo.ExtMethodDemoTest();

            ReadKey();
        }

        private static void LinqOrderBy()
        {
            /*
            *最常见的扩展方法是 LINQ 标准查询运算符，
            * 它将查询功能添加到现有的 System.Collections.IEnumerable 
            * 和 System.Collections.Generic.IEnumerable<T> 类型。
            * 若要使用标准查询运算符，请先使用 using System.Linq 
            * 指令将它们置于范围中。 然后，任何实现了 IEnumerable<T> 
            * 的类型看起来都具有 GroupBy、OrderBy、Average 等实例方法。 
            * 在 IEnumerable< T > 类型的实例（如 List<T> 或 Array）
            * 后键入“dot”时，可以在 IntelliSense 语句完成中看到这些附加方法。
            */

            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);//需要引入System.Linq 
            foreach (var i in result)
            {
                WriteLine(i);
            }
        }

    }
}
