using System;
using CSharpGenerics.LinkedListObjects;
using CSharpGenerics.Variance;
using static System.Console;
using T = CSharpGenerics.LinkedListT;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {




            //泛型接口的协变();
            泛型接口的抗变();
            /*
             * 在具体类中约定了泛型具体的返回类型 或者输入类型
             * 这样泛型被具体化（明确）
             * 
             * 再配合 继承特性 子类与基类之间的转换
             * 实现 子类泛型接口实例 与基类泛型接口实例 之间的相互转换 是程序降低耦合性
             * 协变 out T 可将 子类泛型接口实例 转换为 基类泛型接口实例
             *   IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
             *   IIndex<Shape> shapes = rectangles;
             * 
             * 抗变 in T 可将 基类泛型接口实例 转换为 子类泛型接口实例
             *   IDisplay<Shape> shapeDisplay = new ShapeDisplay();
             *   IDisplay<Rectangle> rectangleDisplay = shapeDisplay;
             * 
             */

            Shape sp = new Shape();
            Rectangle rect = new Rectangle();
            rect =(Rectangle)sp;// 子类的实例指向基类的引用需要类型转换（存在安全隐患）
            sp = rect;//基类实例指向子类的引用是直接的

            ReadKey();
        }

        private static void 非泛型化列表()
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
        }

        private static void 自定义泛型()
        {
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

        }

        private static void 泛型类的静态成员()
        {

            //泛型类的静态成员
            //只能在类的一个实例中共享
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            WriteLine($"StaticDemo<string>.x:{StaticDemo<string>.x}");
            WriteLine($"StaticDemo<int>.x:{StaticDemo<int>.x}");
        }

        private static void 泛型接口的协变()
        {
            
            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();
            //如果IIndex<out T> 去掉out  IIndex<Shape> shapes = rectangles; 编译错误，
            //Rectangle是Shape的子类 由子类泛型转换成基类泛型 需要协变（out T）？
            //IIndex<out T>  约定返回类型只能是T 在具体实现类中IIndex<Rectangle> 返回类型只能是Rectangle
            //Rectangle 是 Shape的子类 可以用父类的实例指向子类的引用进行编程
            IIndex<Shape> shapes = rectangles;

            for (int i = 0; i < shapes.Count; i++)
            {
                WriteLine(shapes[i]);
            }
        }

        private static void 泛型接口的抗变() {
            IDisplay<Shape> shapeDisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;

            IIndex<Rectangle> rectangles = RectangleCollection.GetRectangles();

            shapeDisplay.Show(rectangles[0]);
            rectangleDisplay.Show(rectangles[0]);
        }

    }
}
