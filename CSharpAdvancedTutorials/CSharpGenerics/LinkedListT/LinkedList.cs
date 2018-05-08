using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.LinkedListT
{
    public class LinkedList<T> : IEnumerable<T>//实现IEnumerable<T>泛型接口 泛型有继承性也可继承泛型类
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> AddLast(T node)
        {

            var newNode =new LinkedListNode<T>(node);

            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                LinkedListNode<T> temp = Last;
                Last.Next = newNode;
                Last = newNode;
                Last.Prev = temp;
            }

            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = First;
            while (current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
