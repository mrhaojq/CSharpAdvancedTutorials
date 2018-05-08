using System;
using CSharpGenerics.LinkedListObjects;
using static System.Console;
using T = CSharpGenerics.LinkedListT;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试一般的、非泛型的简化链表类!");
            var list1 = new LinkedList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast("6");

            foreach (var item in list1)
            {
                WriteLine(item);
            }
           

            WriteLine("测试自定义泛型");
            var list2 = new T.LinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(4);
            //list2.AddLast("6");//编译时错误 安全性

            foreach (var item in list2)
            {
                WriteLine(item);//不需要装箱拆箱 性能高
            }
            var list3 = new T.LinkedList<string>();
            list3.AddLast("s2");
            list3.AddLast("s4");
            list3.AddLast("s6");//编译时错误 安全性

            foreach (var item in list3)
            {
                WriteLine(item);//不需要装箱拆箱 性能高
            }

            //泛型类的静态成员
            //只能在类的一个实例中共享
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            WriteLine($"StaticDemo<string>.x:{StaticDemo<string>.x}");
            WriteLine($"StaticDemo<int>.x:{StaticDemo<int>.x}");

            ReadKey();
        }
    }
}
