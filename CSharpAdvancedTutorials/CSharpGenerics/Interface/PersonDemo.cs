using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Interface
{
    public class Person1 : IComparable //老的非泛型接口
    {
        public string LastName { get; set; }

        public int CompareTo(object obj)
        {
            Person1 other = (Person1)obj; //需要进行类型转换
            return this.LastName.CompareTo(other.LastName);
        }
    }

    public class Person2 : IComparable<Person2>
    {
        public string LastName { get; set; }

        public int CompareTo(Person2 other) => LastName.CompareTo(other.LastName);
        //{
        //    return this.LastName.CompareTo(other.LastName);
        //}
    }
}
