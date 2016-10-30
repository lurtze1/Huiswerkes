using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3 {
    class Program {
        static void Main(string[] args) {
            BinaryHeap bh1 = new BinaryHeap(20);
            bh1.addFreely(10);
            bh1.addFreely(4);
            bh1.addFreely(7);
            bh1.addFreely(1);
            bh1.addFreely(3);
            bh1.addFreely(5);
            //bh1.buildHeap();
            //bh1.display();
            Console.WriteLine(bh1.isComplete());
            Console.WriteLine(bh1.isMaxHeap());

            BinaryHeap bh2 = new BinaryHeap(20);
            bh2.addFreely(15);
            bh2.addFreely(5);
            bh2.addFreely(11);
            bh2.addFreely(3);
            bh2.addFreely(4);
            bh2.addFreely(10);
            bh2.addFreely(7);
            bh2.addFreely(1);
            //bh2.buildHeap();
            //bh2.display();
            Console.WriteLine(bh2.isComplete());
            Console.WriteLine(bh2.isMaxHeap());
            
            BinaryHeap bh3 = new BinaryHeap(new int[]{ 10, 4, 7, 1, 3, 0, 5 });
            Console.WriteLine(bh3.isComplete());

            Console.Read();
        }
    }
}
