using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    internal class PriorityQueueT<T> : Queue<T> where T : IComparable<T>
    {
        private static readonly int _defaultCapacity = 100;
        private T[] _array;
        private int _currentSize;

        public PriorityQueueT()
        {
            _currentSize = 0;
            _array = new T[_defaultCapacity + 1];
        }

        public PriorityQueueT(Queue<T> queueueue)
        {
            _currentSize = queueueue.Count;
            PercolateUp(++_currentSize);
            BuildHeap();
        }

        public int Size()
        {
            return _currentSize;
        }

        public new void Clear()
        {
            _currentSize = 0;
        }

        private int compare(T lhs, T rhs)
        {
            return lhs.CompareTo(rhs);
        }

        public T Element()
        {
            if (!_array.Any())
            {
                throw new ArgumentException();
            }
            return _array[1];
        }

        public bool Add(T x)
        {
            if (_currentSize + 1 == _array.Length)
            {
                DoubleArray();
            }
            int hole = ++_currentSize;
            _array[0] = x;

            for (; compare(x, _array[hole/2]) < 0; hole /= 2)
            {
                _array[hole] = _array[hole/2];
            }
            _array[hole] = x;
            return true;
        }

        public T FindMin()
        {
            return _array[1];
        }

        public T Remove()
        {
            var minItem = Element();
            _array[1] = _array[_currentSize--];
            PercolateDown(1);

            return minItem;
        }

        private void PercolateDown(int hole)
        {
            int child;
            var tmp = _array[hole];

            for (; hole*2 <= _currentSize; hole = child)
            {
                child = hole*2;
                if ((child != _currentSize) && (compare(_array[child + 1], _array[child]) < 0))
                {
                    child++;
                }
                if (compare(_array[child], tmp) < 0)
                {
                    _array[hole] = _array[child];
                }
                else
                {
                    break;
                }
            }
            _array[hole] = tmp;
        }

        private void BuildHeap()
        {
            for (int i = _currentSize/2; i > 0; i--)
            {
                PercolateDown(i);
            }
        }

        private void DoubleArray()
        {
            T[] newArray;

            newArray = new T[_array.Length*2];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private string PreOrderPrint(int hole)
        {
            string result = "";
            if ((hole >= 0) && (hole <= _currentSize))
            {
                result += _array[hole] + ", ";
                result += PreOrderPrint(hole*2);
                result += PreOrderPrint(hole*2 + 1);
            }
            return result;
        }

        public void PreOrderPrint()
        {
            Console.WriteLine(PreOrderPrint(1));
        }

        public bool PercolateUp(int hole)
        {
            var x = _array[hole];
            _array[0] = x;

            for (; compare(x, _array[hole/2]) < 0; hole /= 2)
            {
                _array[hole] = _array[hole/2];
            }
            _array[hole] = x;
            return true;
        }
    }


}