using System;

namespace ConsoleApplication1
{
    public class BinaryNode<T> where T : IComparable
    {
        public T Element;
        public int Height = 0;
        public BinaryNode<T> Left;
        public BinaryNode<T> Right;

        public BinaryNode(T data)
        {
            Element = data;
        }
    }
}