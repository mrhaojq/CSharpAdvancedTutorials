using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Extend
{
    //自定义泛型类 继承（实现）泛型接口IEnumberable<T>  泛型参数T要一致 
    //自定义泛型类 需要实现IEnumberable<T>的两个方法
    //LinkedList 必须重复接口（IEnumerable<T>）的泛型类型 T 
    public class LinkedList<T> : IEnumerable<T>
    {
       
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
