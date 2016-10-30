using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4 {
    class Program {
        static void Main(string[] args) {
            Graph g = new Graph();

            g.addVertex("A");
            g.addVertex("B");
            g.addVertex("C");
            g.addVertex("D");
            g.addVertex("E");
            g.addVertex("F");
            g.addVertex("G");
            g.addVertex("H");
            g.addVertex("K");

            g.addEdge("A", "B", 1);
            g.addEdge("A", "G", 1);
            g.addEdge("C", "B", 1);
            g.addEdge("D", "F", 1);
            g.addEdge("D", "G", 1);
            g.addEdge("E", "C", 1);
            g.addEdge("F", "F", 1);
            g.addEdge("G", "D", 1);
            g.addEdge("G", "F", 1);
            g.addEdge("G", "H", 1);
            g.addEdge("H", "E", 1);
            g.addEdge("H", "K", 1);
            g.addEdge("K", "G", 1);

            //Console.WriteLine(g);

            Console.WriteLine("\nB:");
            g.vulAfstand();
            Console.WriteLine(g.toonAfstand());

            Console.WriteLine("\nC:");
            Console.WriteLine("E has cycle: " + g.hasCycle("E"));
            Console.WriteLine("K has cycle: " + g.hasCycle("K"));

            Console.WriteLine("\nD:");
            Console.WriteLine(g.toonCycles());

            Console.Read();
        }
    }
}
