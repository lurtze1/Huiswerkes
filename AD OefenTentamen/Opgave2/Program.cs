using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2 {
    class Program {
        static void Main(string[] args) {
            BinarySearchTree bst = new BinarySearchTree();
            bst.insert(6);
            bst.insert(2);
            bst.insert(8);
            bst.insert(1);
            bst.insert(4);
            bst.insert(3);

            //bst.printInOrder();
            Console.WriteLine(bst.geefEenNaKleinsteElement());

            Console.Read();
        }
    }
}
