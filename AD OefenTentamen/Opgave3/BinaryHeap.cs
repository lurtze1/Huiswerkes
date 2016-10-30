using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3 {
    class BinaryHeapNode {
        private int nodeItem;
        public BinaryHeapNode(int value) {
            nodeItem = value;
        }
        public int getValue() {
            return nodeItem;
        }
        public void setvalue(int id) {
            nodeItem = id;
        }

        public override string ToString() {
            return nodeItem.ToString();
        }
    }

    class BinaryHeap {
        private BinaryHeapNode[] array;
        private int currentSize;
        private int maxSize;

        public BinaryHeap(int size) {
            array = new BinaryHeapNode[size];
            currentSize = 0;
            maxSize = size;
        }

        public BinaryHeap(int[] data) {
            array = new BinaryHeapNode[data.Count()];
            currentSize = data.Count();
            maxSize = data.Count();
            for (int i = 0; i < array.Count(); i++) {
                array[i] = data[i] != 0 ? new BinaryHeapNode(data[i]) : null;
            }
        }

        // 3a
        public bool isComplete() {
            for (int i = 0; i < array.Count() - 1; i++) {
                if (array[i] == null && array[(i+1)] != null)
                    return false;
            }
            return true;
        }

        // 3b
        public bool isMaxHeap() {
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            bool isMax = true;
            while (currentSize > 0) {
                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow) {
                    itemsPerRow *= 2;
                    column = 0;
                }
                int p = j - column - 1 - (column >= (itemsPerRow/2) ? 0 : 1);
                p = p > 0 ? p : 0;
                if (array[j].getValue() > array[p].getValue()) {
                    isMax = false;
                }
            }
            return isMax;
        }

        public bool IsEmpty() {
            return currentSize == 0;
        }

        public bool add(int value) {
            if (currentSize == maxSize)
                return false;
            array[currentSize] = new BinaryHeapNode(value);
            percolateUp(currentSize++);
            return true;
        }

        public void percolateUp(int index) {
            int parent = (index - 1) / 2;
            BinaryHeapNode bottom = array[index];
            while (index > 0 && array[parent].getValue() > bottom.getValue()) {
                array[index] = array[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            array[index] = bottom;
        }

        public int remove() {
            BinaryHeapNode root = array[0];
            array[0] = array[--currentSize];
            percolateDown(0);
            return root.getValue();
        }

        private void percolateDown(int index) {
            int largerChild;
            BinaryHeapNode top = array[index];
            while (index < currentSize / 2) {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && array[leftChild].getValue() > array[rightChild].getValue())
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.getValue() <= array[largerChild].getValue())
                    break;
                array[index] = array[largerChild];
                index = largerChild;
            }
            array[index] = top;
        }

        public void addFreely(int value) {
            array[currentSize] = new BinaryHeapNode(value);
            currentSize++;
        }

        public void buildHeap() {
            for (int i = currentSize - 1; i > 0; i--)
                percolateUp(i);
        }

        public void display() {
            Console.WriteLine();
            Console.Write("Elements of the Heap Array are : ");
            for (int m = 0; m < currentSize; m++)
                if (array[m] != null)
                    Console.Write(array[m] + " ");
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0) {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(array[j]);

                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow) {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                } else
                    for (int k = 0; k < emptyLeaf * 2 - 2; k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
        }
    }
}
