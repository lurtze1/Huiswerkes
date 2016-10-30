using System;
using ConsoleApplication1;

namespace AD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
//            // Create an unsorted array of string elements
//            string[] unsorted = {"z", "e", "", "x", "c", "m", "q", "a", "b", "c", "d", "9", "11", "33"};
//
//            // Print the unsorted array
//            for (int i = 0; i < unsorted.Length; i++)
//            {
//                Console.Write(unsorted[i] + " ");
//            }
//            Console.WriteLine();
//
//            // Sort the array
//            QuickSort.Sort(unsorted, 0, unsorted.Length - 1);
//            // Print the sorted array
//            for (int i = 0; i < unsorted.Length; i++)
//            {
//                Console.Write(unsorted[i] + " ");
//            }
//
//            Console.WriteLine();
//
//            Console.ReadLine();
//
//            var tree = new BinaryTree<int>();
//
//            tree.Insert(5);
//            tree.Insert(3);
//            tree.Insert(7);
//
//            tree.InOrderPrint();
//            Console.WriteLine("----------------");
//            tree.PreOrderPrint();
//            Console.WriteLine("----------------");
//            tree.PostOrderPrint();
//            var queue = new PriorityQueue {101010, 100, 7, 9, 6};
//            queue.PreOrderPrint();
//            queue.remove();
//            queue.PreOrderPrint();
//            queue.Add(1);
//            queue.PreOrderPrint();
//            queue.Add(102010);
//
//            var g = new Graph();
//
//            g.AddEdge("Henk", "Tank", 10.1);
//            g.AddEdge("Piet", "Henk", 1);
//            g.AddEdge("Adrian", "Piet", 2);
//            g.AddEdge("Adrian", "Tank", 5);
//
//            g.Unweighted("Henk");
//
//            AvlTree<int> avlTree = new AvlTree<int>();
//            avlTree.Add(2);
//            avlTree.Add(1);
//            avlTree.Add(0);
//            avlTree.Add(-1);
//            avlTree.Add(-2);
//            avlTree.Add(3);
//            avlTree.Add(5);
//            avlTree.Add(4);
//
//            avlTree.DisplayTree();
//
//            Console.ReadLine();
//
            PriorityQueueT<int> queue = new PriorityQueueT<int>();
            queue.Add(10);
            queue.Add(100);
            queue.Add(12);
            queue.Add(5);
            queue.PreOrderPrint();
        }
    }
}