import Week2.MyArrayList;
import Week2.MyLinkedList;
import Week3.RecursionCity;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by lurtze1 on 14-Sep-16.
 */
public class Week1 {
    public static void main(String[] args) {
        {

            //ArrayList
            ArrayList<Integer> testlist = new ArrayList<>(2);
            MyArrayList list = new MyArrayList(2);
            testlist.add(10);
            testlist.add(10);
            testlist.add(10);
            list.add(10);
            list.add(10);
            list.add(10);
            System.out.println(testlist.toString());
            System.out.println(list.countOccurences(10));
            list.print();
            list.clear();
            list.print();
            list.add(10);
            list.add(20);
            list.print();
            list.get(1);


           //linkedlist
            MyLinkedList<Integer> list2 = new MyLinkedList<>();
            list2.addFirst(10);
            list2.addFirst(20);
            list2.insert(1, 30);
            list2.print();


            //stack
            RecursionCity city = new RecursionCity();
            System.out.println(city.sum(2022089123));
            System.out.println(city.reverse("kcid"));

            System.out.println(city.RecursionFaculty(11));
            System.out.println(city.Faculty(11));
            System.out.println(city.RecursiveFibonaci(11));
            System.out.println(city.Fibonaci(11));
            System.out.println(city.OmenOm(10000));

            List<Integer> list3 = new ArrayList<>();
            list3.add(5);
            list3.add(3);
            list3.add(2);
            list3.add(4);
            list3.add(5);
            list3.add(2);
            list3.add(18);
            list3.add(-2);
            System.out.println(list3.toString());
            list3 = city.InsertionSort(list3);
            System.out.println(list3.toString());
            list3.add(10);
            list3.add(15);
            list3.add(22);
            city.mergeSort(list3);
            city.printForward(list3, 2);
            city.printBackward(list3, 2);

        }
    }
}
