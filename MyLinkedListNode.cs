using System;
using System.Collections.Generic;

namespace GR15_05312022
{
    class MyLinkedListNode<T>
    {
        public T Value { get; set; }
        public MyLinkedListNode<T> Next { get; set; }

        public MyLinkedListNode<T> Previous { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
