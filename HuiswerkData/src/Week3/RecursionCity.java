package Week3;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by lurtze1 on 16-Sep-16.
 */
public class RecursionCity {
    public RecursionCity() {

    }

    public int sum(int n) {
        int r;
        if (n > 0) {
            r = n % 10;
            return sum(n / 10) + r;
        } else {
            return 0;
        }
    }

    public String reverse(String s) {
        String r;
        if (s.length() > 0) {
            r = s.substring(s.length() - 1);
            return r + reverse(s.substring(0, s.length() - 1));
        } else {
            return "";
        }
    }

    public int RecursionFaculty(int n) {
        int result;
        if (n > 0) {
            result = n;
            return RecursionFaculty(n - 1) * result;
        } else {
            return 1;
        }
    }

    public int Faculty(int n) {
        int result = n;
        for (int i = n - 1; i > 0; i--) {
            result = result * i;
        }
        return result;
    }

    public int RecursiveFibonaci(int index) {
        if (index <= 1)
            return index;
        else
            return RecursiveFibonaci(index - 1) + RecursiveFibonaci(index - 2);

    }

    public int Fibonaci(int index) {
        if (index > 1) {
            int r = 1;
            int currentNumber;
            int previousNumber = 0;
            for (int i = 1; i < index; i++) {
                currentNumber = r;
                r += previousNumber;
                previousNumber = currentNumber;
            }
            return r;
        }
        return 1;
    }

    public int OmenOm(int n) {
        int r;
        if (n > 2) {
            r = n;
            return OmenOm(n - 2) + r;
        } else {
            return n;
        }
    }

    public void printForward(List<Integer> theList, int i) {
        if (i < theList.size() && i >= 0) {
            System.out.println(theList.get(i) + " ");
            printForward(theList, (i + 1));
        }
    }

    public void printBackward(List<Integer> theList, int i) {
        if (i < theList.size() && i >= 0) {
            printBackward(theList, (i + 1));
            System.out.println(theList.get(i) + " ");
        }
    }

    public List<Integer> InsertionSort(List<Integer> theList) {
        int temp1;
        int ii;
        for (int i = 1; i < theList.size(); i++) {
            temp1 = theList.get(i);
            ii = i;
            for (; ii > 0 && temp1 < theList.get(ii - 1); ii--) {
                theList.set(ii, theList.get(ii - 1));

            }
            theList.set(ii, temp1);
        }
        return theList;
    }

    public void mergeSort(List<Integer> theList) {
        ArrayList<Integer> tmpList = new ArrayList<>(theList.size());
        for (int i = 0; i < theList.size(); i++) {
            tmpList.add(0);
        }
        this.mergeSort(theList, tmpList, 0, theList.size() - 1);
    }

    private void mergeSort(List<Integer> theList, List<Integer> tmpList, int left, int right) {
        if (left < right) {
            int center = (left + right) / 2;
            mergeSort(theList, tmpList, left, center);
            mergeSort(theList, tmpList, center + 1, right);
            merge(theList, tmpList, left, center + 1, right);

        }
    }

    private void merge(List<Integer> theList, List<Integer> tmpList, int leftPos, int rightPos, int rightEnd) {
        int leftEnd = rightPos - 1;
        int tmpPos = leftPos;
        int numElements = rightEnd - leftPos + 1;

        while (leftPos <= leftEnd && rightPos <= rightEnd) {
            if (theList.get(leftPos) <= theList.get(rightPos)) {
                tmpList.set(tmpPos++, theList.get(leftPos++));
            } else {
                tmpList.set(tmpPos++, theList.get(rightPos++));
            }
        }
        while (leftPos <= leftEnd) {
            tmpList.set(tmpPos++, theList.get(leftPos++));
        }
        while (rightPos <= rightEnd) {
            tmpList.set(tmpPos++, theList.get(rightPos++));
        }

        for (int i = 0; i < numElements; i++, rightEnd--) {
            theList.set(rightEnd, tmpList.get(rightEnd));
        }
    }
}
