using System;

namespace AD
{
    public class BinaryTree
    {
        protected BinaryNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        private int? ElementAt(BinaryNode t)
        {
            return t == null ? null : t.Element;
        }

        public int? Find(int x)
        {
            return ElementAt(Find(x, Root));
        }


        public void Insert(int x)
        {
            Root = Insert(x, Root);
        }

        public void Remove(int x)
        {
            Root = Remove(x, Root);
        }

        public void RemoveMin()
        {
            Root = RemoveMin(Root);
        }

        public int? FindMin()
        {
            return ElementAt(FindMin(Root));
        }

        public int? FindMax()
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

        private BinaryNode Find(int x, BinaryNode t)
        {
            while (t != null)
            {
                if (x < t.Element)
                {
                    t = t.Left;
                }
                else if (x > t.Element)
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


        private BinaryNode FindMin(BinaryNode t)
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

        private BinaryNode FindMax(BinaryNode t)
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

        private BinaryNode Insert(int x, BinaryNode t)
        {
            if (t == null)
            {
                t = new BinaryNode(x);
            }
            else if (x < t.Element)
            {
                t.Left = Insert(x, t.Left);
            }
            else if (x > t.Element)
            {
                t.Right = Insert(x, t.Right);
            }
            else
            {
                throw new ArgumentException(x.ToString());
            }
            return t;
        }

        protected BinaryNode RemoveMin(BinaryNode t)
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

        protected BinaryNode Remove(int x, BinaryNode t)
        {
            if (t == null)
            {
                throw new ArgumentException(t.ToString());
            }
            if (x < t.Element)
            {
                t.Left = Remove(x, t.Left);
            }
            else if (x > t.Element)
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

        private string PreOrderPrint(BinaryNode t)
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

        private string InOrderPrint(BinaryNode t)
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

        private string PostOrderPrint(BinaryNode t)
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