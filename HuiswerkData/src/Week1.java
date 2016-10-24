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
            /*ArrayList testlist = new ArrayList(2);
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
            list.get(1);*/


            //linkedlist
            /*MyLinkedList<Integer> list2 = new MyLinkedList<Integer>();
            list2.addFirst(new Integer(10));
            list2.addFirst(new Integer(20));
            list2.insert(1, new Integer(30));
            list2.print();
*/

            //stack
            RecursionCity city = new RecursionCity();
            /*System.out.println(city.sum(2022089123));
            System.out.println(city.reverse("kcid"));*/

       /*     System.out.println(city.RecursionFaculty(11));
            System.out.println(city.Faculty(11));
            System.out.println(city.RecursiveFibonaci(11));
            System.out.println(city.Fibonaci(11));
            System.out.println(city.OmenOm(10000));*/

            List<Integer> list = new ArrayList<>();
            list.add(5);
            list.add(3);
            list.add(2);
            list.add(4);
            list.add(5);
            list.add(2);
            list.add(18);
            list.add(-2);
            System.out.println(list.toString());
            list = city.InsertionSort(list);
            System.out.println(list.toString());
list.add(10);
            list.add(15);
            list.add(22);
            city.mergeSort(list);
            System.out.println(list.toString());

        }
    }
}
