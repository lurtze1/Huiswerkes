using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2 {
    class BinarySearchTreeNode {
        public int data;
        public BinarySearchTreeNode left;
        public BinarySearchTreeNode right;

        public BinarySearchTreeNode(int x) {
            data = x;
            left = null;
            right = null;
        }

        public void insert(int data) {
            if (this.data < data) {
                if (right == null) {
                    right = new BinarySearchTreeNode(data);
                } else {
                    right.insert(data);
                }
            } else if (this.data > data) {
                if (left == null) {
                    left = new BinarySearchTreeNode(data);
                } else {
                    left.insert(data);
                }
            }
        }

        public void printInOrder() {
            if (left != null) left.printInOrder();
            Console.WriteLine(data);
            if (right != null) right.printInOrder();
        }
    }
}
