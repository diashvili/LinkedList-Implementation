using System;
using System.Collections;
using System.Collections.Generic;

namespace GR15_05312022
{
    class MyLinkedList<T> : IEnumerable<T>
    {
        private MyLinkedListNode<T> _firstNode;

        public void AddFirst(MyLinkedListNode<T> node)
        {
            if (_firstNode != null)
            {
                node.Next = _firstNode;    
                _firstNode = node;
                node = _firstNode;
                return;
            }
            _firstNode = node;
        }

        public MyLinkedListNode<T> AddFirst(T value)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>() { Value = value };
            AddFirst(node);
            return node;
        }

        public void AddLast(MyLinkedListNode<T> node)
        {
            if (_firstNode != null)
            {
                MyLinkedListNode<T> lastNode = GetLastNode();
                lastNode.Next = node;
                node.Previous = lastNode;
                return;
            }
            _firstNode = node;
        }

        public MyLinkedListNode<T> AddLast(T value)
        {
            MyLinkedListNode<T> node = new MyLinkedListNode<T>() { Value = value };
            AddLast(node);
            return node;
        }

        private MyLinkedListNode<T> GetLastNode()
        {
            MyLinkedListNode<T> node = _firstNode;
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
            if (node.Next != null)
            {
                newNode.Next = node.Next;
                node = newNode;
                node.Next = newNode;

            }
            else
            {
                node.Next = newNode;
            }
               
        }

        public MyLinkedListNode<T> AddAfter(MyLinkedListNode<T> node, T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>() { Value = value };
            AddAfter(node, newnode);
            return node;
        }

        public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
                  
                newNode.Previous = node.Previous;
                node = newNode;
                node.Previous = newNode;
            
        }

        public MyLinkedListNode<T> AddBefore(MyLinkedListNode<T> node, T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>() { Value = value };
            AddBefore(node, newnode);
            return node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            return new MyLinkedListEnumerator<T>(_firstNode);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class MyLinkedListEnumerator<T> : IEnumerator<T>
    {
        
        private MyLinkedListNode<T> _currentnode = null;
        private MyLinkedListNode<T> _firstnode = null;

        private int _count = 0;
        public MyLinkedListEnumerator(MyLinkedListNode<T> node)
        {
            
            _currentnode = node;
            _firstnode = node;

        }
        public T Current
        {
            get
            {       
                return _currentnode.Value;
            }
        }

        public bool MoveNext()
        {
            if(_count == 0)
            {
                _count++;
                return true;
            }
            if (_currentnode.Next != null)
            {
                _currentnode = _currentnode.Next;
                _count++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentnode = _firstnode;
            _count = 0;
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
