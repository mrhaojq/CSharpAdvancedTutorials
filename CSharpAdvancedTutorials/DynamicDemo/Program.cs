using System;
using static System.Console;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/dynamic
            Console.WriteLine("在通过 dynamic 类型实现的操作中，该类型的作用是绕过编译时类型检查。 改为在运行时解析这些操作。");
            DynamicVsObject();

            ExampleClass ec = new ExampleClass();
            WriteLine(ec.exampleMethod(10));
            WriteLine(ec.exampleMethod("value"));

            dynamic dynamic_ec = new ExampleClass();
            WriteLine(dynamic_ec.exampleMethod(10));//无智能感知，编译可通过，在运行时解析

            Advanced();

            ReadKey();
        }

        private static void DynamicVsObject()
        {
            dynamic dyn = 1;
            object obj = 1;

            dyn = dyn + 3; //dynamic 绕过编译时检测，在运行时解析
            //obj = obj + 3; //编译时错误

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            WriteLine($"dynamic dyn = 1; dyn type is {dyn.GetType()}");
            WriteLine($"object obj = 1; obj type is {obj.GetType()}");
        }

        private static async void Advanced()
        {

            var queryString = "http://112.124.19.35:9988/odc/?do=getwf&citysn=101010100&_t" + DateTime.Now.Ticks;

            dynamic result1 = await DataService.GetWeatherDynamic(queryString).ConfigureAwait(false);
            WFEntityInfo weather1 = new WFEntityInfo();
            ////if (results["WFEntityInfo"]!=null)
            ////{
            ////  如何判断还有待研究
            ////}
            if (result1 != null)
            {
                weather1.dayTemp = (string)result1["dayTemp"];
            }


            dynamic result2 =  DataService.GetWeatherDynamic(queryString).Result;
            WFEntityInfo weather2 = new WFEntityInfo();
            if (result2 != null)
            {
                weather2.dayTemp = (string)result2["dayTemp"];
            }

            //放在同步方法中和放在异步方法中没有区别  private static  void Advanced() //  private static async  void Advanced()
            WFEntityInfo weather3 = DataService.GetWeatherGeneric<WFEntityInfo>(queryString).Result;

        }
    }
}
