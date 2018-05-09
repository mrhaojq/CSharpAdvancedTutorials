using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Variance
{
    /// <summary>
    /// 如果泛型接口用in关键字进行标注，泛型接口就是抗变的，这样，接口只能把泛型类型T用作其方法的输入
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public interface IDisplay<in T>
    {
        void Show(T item);
    }
}
