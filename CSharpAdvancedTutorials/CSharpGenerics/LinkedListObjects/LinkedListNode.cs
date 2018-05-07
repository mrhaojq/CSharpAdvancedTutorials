using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.LinkedListObjects
{
  public  class LinkedListNode
    {
        public object Value { get; private set; }
        public LinkedListNode(object value)
        {
            this.Value = value;
        }

        public LinkedListNode Next { get; internal set; }
        public LinkedListNode Prev { get; internal set; }
    }
}
