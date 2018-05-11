using System;
using System.Collections.Generic;
using System.Text;
using CSharpExtensionMethod;
using static System.Console;

namespace CSharpExtensionMethod.ExtensionMethodsDemo1
{
    class A : IMyInterface
    {
        public void MethodB()
        {
            WriteLine("A.MethodB()");
        }
    }

    class B : IMyInterface
    {
        public void MethodB()
        {
            WriteLine("B.MethodB()");
        }

        //Extensions.MethodA(this IMyInterface myInterface, string s) 
        public void MethodA(int i)
        {
            WriteLine("B.MethodA(int i)");
        }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }

    public static class ExtMethodDemo
    {
        public static void ExtMethodDemoTest()
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.MethodA(1);
            a.MethodA("Hello");
            a.MethodB();

            b.MethodA(1);
            b.MethodA("Hello");
            b.MethodB();

            c.MethodA(1);
            c.MethodA("Hello");
            c.MethodB();
        }

    }
}
