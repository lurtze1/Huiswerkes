using System;
using ConsoleApplication1.Heap;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opdracht_1.printLetters(3);
            Console.ReadLine();
            Opdracht_1.printLetters(0);
            Console.ReadLine();
            Opdracht_1.printLetters2(3, 5);
            Console.ReadLine();
            Opdracht_1.printLetters2(0, 2);
            Console.ReadLine();*/

            /* BinaryTree<int> tree = new BinaryTree<int>();
             tree.Insert(6);
             tree.Insert(8);
             tree.Insert(2);
             tree.Insert(4);
             tree.Insert(1);
             tree.Insert(3);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
             tree.Remove(1);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
             tree.Remove(2);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
             tree.Remove(3);
             tree.Remove(4);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
             tree.Insert(7);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
             tree.Remove(7);
             tree.Remove(8);
             tree.Insert(20);
             tree.Insert(30);
             Console.WriteLine(tree.GeefEenNaKleinsteElement().Element);
 
             BinaryTree<int> tree2 = new BinaryTree<int>();
             tree2.Insert(5);
             Console.WriteLine(tree2.GeefEenNaKleinsteElement().Element);
             tree2.Insert(2);
             Console.WriteLine(tree2.GeefEenNaKleinsteElement().Element);*/


            MaxHeap<int> queue = new MaxHeap<int>();
            queue.Add(10);
            queue.Add(100);
            queue.Add(12);
            queue.Add(5);
            queue.PreOrderPrint();
            Console.WriteLine(queue.IsMaxHeap());
            MaxHeap<int> queue2 = new MaxHeap<int>();
            int[] ArrayOne = new int[20];
            ArrayOne[1] = 10;
            ArrayOne[2] = 4;
            ArrayOne[4] = 1;
            ArrayOne[5] = 3;
            ArrayOne[3] = 7;
            ArrayOne[7] = 5;
            int[] ArrayTwo = new int[20];
            ArrayTwo[1] = 15;
            ArrayTwo[2] = 5;

            queue2.InsertArray(ArrayTwo);
            Console.WriteLine(queue2.NumberOfNodes());
        }
    }
}