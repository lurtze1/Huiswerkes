using System;

namespace AD
{
    public class BinaryTree<T> where T : IComparable
    {
        protected BinaryNode<T> Root;

        public BinaryTree()
        {
            Root = null;
        }

        private T ElementAt(BinaryNode<T> t)
        {
            return t.Element;
        }

        public T Find(T x)
        {
            return ElementAt(Find(x, Root));
        }


        public void Insert(T x)
        {
            Root = Insert(x, Root);
        }

        public void Remove(T x)
        {
            Root = Remove(x, Root);
        }

        public void RemoveMin()
        {
            Root = RemoveMin(Root);
        }

        public T FindMin()
        {
            return ElementAt(FindMin(Root));
        }

        public T FindMax()
        {
            return ElementAt(FindMax(Root));
        }

        public void MakeEmpty()
        {
            Root = null;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        private BinaryNode<T> Find(T x, BinaryNode<T> t)
        {
            while (t != null)
            {
                if (x.CompareTo(t.Element) < 0)
                {
                    t = t.Left;
                }
                else if (x.CompareTo(t.Element) > 0)
                {
                    t = t.Right;
                }
                else
                {
                    return t;
                }
            }
            return null;
        }


        private BinaryNode<T> FindMin(BinaryNode<T> t)
        {
            if (t != null)
            {
                while (t.Left != null)
                {
                    t = t.Left;
                }
            }
            return t;
        }

        private BinaryNode<T> FindMax(BinaryNode<T> t)
        {
            if (t != null)
            {
                while (t.Right != null)
                {
                    t = t.Right;
                }
            }
            return t;
        }

        private BinaryNode<T> Insert(T x, BinaryNode<T> t)
        {
            if (t == null)
            {
                t = new BinaryNode<T>(x);
            }
            else if (x.CompareTo(t.Element) < 0)
            {
                t.Left = Insert(x, t.Left);
            }
            else if (x.CompareTo(t.Element) > 0)
            {
                t.Right = Insert(x, t.Right);
            }
            else
            {
                throw new ArgumentException(x.ToString());
            }
            return t;
        }

        protected BinaryNode<T> RemoveMin(BinaryNode<T> t)
        {
            if (t == null)
            {
                throw new ArgumentException(t.ToString());
            }
            if (t.Left != null)
            {
                t.Left = RemoveMin(t.Left);
                return t;
            }
            return t.Right;
        }

        protected BinaryNode<T> Remove(T x, BinaryNode<T> t)
        {
            if (t == null)
            {
                throw new ArgumentException(t.ToString());
            }
            if (x.CompareTo(t.Element) < 0)
            {
                t.Left = Remove(x, t.Left);
            }
            else if (x.CompareTo(t.Element) < 0)
            {
                t.Right = Remove(x, t.Right);
            }
            else if ((t.Left != null) && (t.Right != null))
            {
                t.Element = FindMin(t.Right).Element;
                t.Right = RemoveMin(t.Right);
            }
            else
            {
                t = t.Left != null ? t.Left : t.Right;
            }
            return t;
        }

        public void PreOrderPrint()
        {
            Console.WriteLine(PreOrderPrint(Root));
        }

        public void InOrderPrint()
        {
            Console.WriteLine(InOrderPrint(Root));
        }

        public void PostOrderPrint()
        {
            Console.WriteLine(PostOrderPrint(Root));
        }

        private string PreOrderPrint(BinaryNode<T> t)
        {
            string result = "";
            result += t.Element + ", ";
            if (t.Left != null)
            {
                result += PreOrderPrint(t.Left);
            }
            if (t.Right != null)
            {
                result += PreOrderPrint(t.Right);
            }
            return result;
        }

        private string InOrderPrint(BinaryNode<T> t)
        {
            string result = "";

            if (t.Left != null)
            {
                result += PreOrderPrint(t.Left);
            }
            result += t.Element + ", ";
            if (t.Right != null)
            {
                result += PreOrderPrint(t.Right);
            }
            return result;
        }

        private string PostOrderPrint(BinaryNode<T> t)
        {
            string result = "";

            if (t.Left != null)
            {
                result += PreOrderPrint(t.Left);
            }

            if (t.Right != null)
            {
                result += PreOrderPrint(t.Right);
            }
            result += t.Element + ", ";
            return result;
        }
    }
}