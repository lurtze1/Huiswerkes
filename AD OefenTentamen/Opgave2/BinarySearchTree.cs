using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2 {
    class BinarySearchTree {
        public BinarySearchTreeNode root { get; set; }

        public BinarySearchTree() {
            root = null;
        }

        public int geefEenNaKleinsteElement() {
            BinarySearchTreeNode t = root;
            BinarySearchTreeNode p = null;
            if (t != null) { 
                while (t.left != null) {
                    p = t;
                    t = t.left;
                }
                while (t.right != null) {
                    if (t.right.data < p.data) { p = t.right; }
                    t = t.right;
                    while (t.left != null) {
                        if (t.left.data < p.data) { p = t.left; }
                        t = t.left;
                    }
                }
            }
            
            return p.data;
        }

        public void insert(int data) {
            if (root == null) {
                root = new BinarySearchTreeNode(data);
            } else {
                root.insert(data);
            }
        }

        public void printInOrder() {
            root.printInOrder();
        }
    }
}
