/*
 * 反射指程序可以访问、检测和修改它本身状态或行为的一种能力。
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRelection
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //使用反射读取属性
            System.Reflection.MemberInfo info = typeof(UseAttribute);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (var item in attributes)
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine();

            ExecuteRectangle e = new ExecuteRectangle();
            e.ExeRectangle();

            Console.ReadKey();
       
        }
    }
}
