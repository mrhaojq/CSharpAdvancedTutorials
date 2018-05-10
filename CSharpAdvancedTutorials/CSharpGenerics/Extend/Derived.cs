using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Extend
{
    //自定义定义泛型基类
    public class Base<T>
    {
    }

    //自定义泛型类 继承自定义泛型基类
    //必须重复基类Base<T>的的泛型类型T
    //或者必须指定基类的类型
    public class Derived<T> : Base<T>
    {
    }

    //或者必须指定基类的类型
    public class Derived2<T> : Base<string>
    {

    }

    /*
     * 派生类也可以是非泛型类（具体类）
     * 可以定义一个抽象泛型基类
     * 在派生类中用一个具体的类实现
     * 这允许对特定的类型执行特殊的操作
     */
    //自定义抽象泛型类
    public abstract class Calc<T>
    {
        public abstract T Add(T x, T y);
        public abstract T Sub(T x, T y);
    }

    public class IntCalc : Calc<int>
    {
        public override int Add(int x, int y) => x + y;//避免装箱拆箱 类型安全

        public override int Sub(int x, int y) => x - y;
    }

    public class StringCalc : Calc<String>
    {
        public override string Add(string x, string y) => x + y;

        public override string Sub(string x, string y) => x.Replace(y,"");
    }
}
