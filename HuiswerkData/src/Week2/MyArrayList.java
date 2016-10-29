package Week2;

/**
 * Created by lurtze1 on 14-Sep-16.
 */
public class MyArrayList implements SimpleArrayList {
    public Integer[] internalArray;

    //O(c)
    public MyArrayList(int size) {
        if (size > 0) {
            internalArray = new Integer[size];
        }
    }

    //O(N)
    @Override
    public void add(int n) {
        if (internalArray[internalArray.length - 1] != null) {
            Integer[] newArray = new Integer[internalArray.length * 2];
            for (int i = 0; i < internalArray.length; i++) {
                newArray[i] = internalArray[i];
            }
            internalArray = newArray;
        }
        for (int i = 0; i < internalArray.length; i++) {
            if (internalArray[i] == null) {
                internalArray[i] = n;
                break;
            }
        }
    }

    //O(c)
    @Override
    public int get(int index) {
        if (internalArray[index] != null) {
            return internalArray[index];
        } else {
            throw new NullPointerException("key at index is null, cannot return an value");
        }
    }

    //O(c)
    @Override
    public void set(int index, int n) {
        if (index < 0 || index >= internalArray.length) {
            throw new NullPointerException("key at index is null, cannot return an value");
        } else {
            internalArray[index] = n;
        }
    }

    //O(n)
    @Override
    public void print() {
        System.out.print("[");
        for (Integer nummer : internalArray) {
            if (nummer != null) {
                System.out.print(nummer + ",");
            }

        }
        System.out.print("]");
        System.out.println("");
    }

    //O(c)
    @Override
    public void clear() {
        this.internalArray = new Integer[internalArray.length];
    }

    //O(n)
    @Override
    public int countOccurences(int n) {
        int counter = 0;
        for (Integer nummer : internalArray) {
            if (nummer != null && nummer == n) {
                counter++;
            }
        }
        return counter;
    }

    public void InsertionSort() {
        Integer[] sortedArray = new Integer[internalArray.length];
    }
}
