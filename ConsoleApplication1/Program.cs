using ConsoleApplication1;

namespace AD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*// Create an unsorted array of string elements
            string[] unsorted = {"z", "e", "", "x", "c", "m", "q", "a", "b", "c", "d", "9", "11", "33"};

            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();

            // Sort the array
            QuickSort.Sort(unsorted, 0, unsorted.Length - 1);
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();*/

            //Note make better version that works backwards :P

            /*var tree = new BinaryTree();

            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);

            tree.InOrderPrint();
            Console.WriteLine("----------------");
            tree.PreOrderPrint();
            Console.WriteLine("----------------");
            tree.PostOrderPrint();*/
            var queue = new PriorityQueue();
            queue.Add(101010);
            queue.Add(100);
            queue.Add(7);
            queue.Add(9);
            queue.Add(6);
            queue.PreOrderPrint();
            queue.remove();
            queue.PreOrderPrint();
            queue.Add(1);
            queue.PreOrderPrint();
            queue.Add(102010);

            var g = new Graph();

            g.AddEdge("Henk", "Tank", 10.1);
            g.AddEdge("Piet", "Henk", 1);
            g.AddEdge("Adrian", "Piet", 2);
            g.AddEdge("Adrian", "Tank", 5);

            g.Unweighted("Henk");
        }
    }
}