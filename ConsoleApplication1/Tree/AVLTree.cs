using System;

namespace AD
{
    public class AvlTree<T> where T : IComparable
    {
        BinaryNode<T> root;

        public AvlTree()
        {
        }

        public void Add(T data)
        {
            BinaryNode<T> newItem = new BinaryNode<T>(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
                //root = null so we dont lose track of the root and we assign a new root if necessary
            }
        }

        private BinaryNode<T> RecursiveInsert(BinaryNode<T> current, BinaryNode<T> n)
        {
            if (current == null) //base case, we reach this when we go left or right until current is null
            {
                current = n;
                return current;
            }
            else if (n.Element.CompareTo(current.Element) < 0) //if the new node is less than the current node
            {
                current.Left = RecursiveInsert(current.Left, n); //go left
                current = balance_tree(current); //calling balance after recursion
            }
            else if (n.Element.CompareTo(current.Element) > 0) //if the new node is greater than the current node
            {
                current.Right = RecursiveInsert(current.Right, n);
                current = balance_tree(current);
            }
            return current;
        }

        private BinaryNode<T> balance_tree(BinaryNode<T> current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.Left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.Right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }

        public void Delete(T target)
        {
            root = Delete(root, target);
        }

        public void Find(T key)
        {
            if (Find(key, root).Element.Equals(key))
            {
                Console.WriteLine("{0} was found!", key);
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }

        private BinaryNode<T> Find(T target, BinaryNode<T> current)
        {
            if (target.CompareTo(current.Element) < 0)
            {
                if (target.Equals(current.Element))
                {
                    return current;
                }
                else
                    return Find(target, current.Left);
            }
            else
            {
                if (target.Equals(current.Element))
                {
                    return current;
                }
                else
                    return Find(target, current.Right);
            }
        }

        public void DisplayTree()
        {
            InOrderDisplayTree(root);
            Console.ReadLine();
        }

        private void InOrderDisplayTree(BinaryNode<T> current)
        {
            if (current != null)
            {
                InOrderDisplayTree(current.Left);
                Console.Write("({0}) ", current.Element);
                InOrderDisplayTree(current.Right);
            }
        }

        private int max(int l, int r) //returns maximum of two integers
        {
            return l > r ? l : r;
        }

        private int CalculateHeight(BinaryNode<T> current)
        {
            if (current != null)
            {
                int height = 0;
                int l = 0;
                int r = 0;
                if (current.Left != null)
                {
                    l = CalculateHeight(current.Left);
                }
                if (current.Right != null)
                {
                    r = CalculateHeight(current.Right);
                }

                int m = max(l, r);
                height = m + 1;
                current.Height = height;
                return current.Height;
            }
            return 0;


        }

        public void RecalculateHeight()
        {
            CalculateHeight(root);
        }

        private int getHeight(BinaryNode<T> current)
        {
            if (current.Height == 0)
            {
                CalculateHeight(current);
            }
            return current.Height;
        }

        private int balance_factor(BinaryNode<T> current)
        {
            int l = CalculateHeight(current.Left);
            int r = CalculateHeight(current.Right);
            int bFactor = l - r;
            return bFactor;
        }

        private BinaryNode<T> RotateRR(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Right;
            parent.Right = pivot.Left;
            pivot.Left = parent;
            return pivot;
        }

        private BinaryNode<T> RotateLL(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }

        private BinaryNode<T> RotateLR(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Left;
            parent.Left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private BinaryNode<T> RotateRL(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Right;
            parent.Right = RotateLL(pivot);
            return RotateRR(parent);
        }

        private BinaryNode<T> Delete(BinaryNode<T> current, T target)
        {
            BinaryNode<T> parent;
            if (current == null)
            {
                return null;
            }


            //left subtree
            if (target.CompareTo(current.Element) < 0)
            {
                current.Left = Delete(current.Left, target);
                if (balance_factor(current) == -2)
                {
                    if (balance_factor(current.Right) <= 0)
                    {
                        current = RotateRR(current);
                    }
                    else
                    {
                        current = RotateRL(current);
                    }
                }
            }
            //right subtree
            else if (target.CompareTo(current.Element) > 0)
            {
                current.Right = Delete(current.Right, target);
                if (balance_factor(current) == 2)
                {
                    if (balance_factor(current.Left) <= 0)
                    {
                        current = RotateLL(current);
                    }
                    else
                    {
                        current = RotateLR(current);
                    }
                }
            }
            //if target is found
            else
            {
                if (current.Right != null)
                {
                    //delete its inorder successor
                    parent = current.Right;
                    while (parent.Left != null)
                    {
                        parent = parent.Left;
                    }
                    current.Element = parent.Element;
                    current.Right = Delete(current.Right, parent.Element);
                    if (balance_factor(current) == 2) //rebalancing
                    {
                        if (balance_factor(current.Left) <= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                else
                {
                    return current.Left;
                }
            }

            return current;
        }
    }
}