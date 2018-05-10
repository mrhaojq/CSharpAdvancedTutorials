using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.LinkedListT
{
   public class LinkedListNode<T>
    {
        public T Value { get; private set; }
        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Prev { get; internal set; }

        public LinkedListNode(T value)
        {
            this.Value = value;
        }
    }
}
