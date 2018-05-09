using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Variance
{
    // 泛型接口的协变 泛型用out关键字标注 返回类型只能是T
    public interface IIndex<out T>
    {
        //从一个只读的索引器中返回这个类型
        T this[int index] { get; }
        int Count { get; }
    }
}
