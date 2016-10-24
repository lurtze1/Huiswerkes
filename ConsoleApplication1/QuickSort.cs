using System;

namespace AD
{
    public class QuickSort
    {

        public static void Sort(IComparable[] list, int left, int right)
        {
            IComparable pivot;
            int countLeft = left, countRight = right;
            if (left + 1 >= right)
            {
                return;
            }
            if ((list[left].CompareTo(list[right]) > 0) && (list[left].CompareTo(list[(left + right)/2]) < 0))
            {
                pivot = list[left];
            }
            else if ((list[right].CompareTo(list[left]) > 0) && (list[right].CompareTo(list[(left + right)/2]) < 0))
            {
                pivot = list[right];
            }
            else
            {
                pivot = list[(left + right)/2];
            }
            while (countLeft <= countRight)
            {
                while (list[countLeft].CompareTo(pivot) < 0)
                {
                    countLeft++;
                }
                while (list[countRight].CompareTo(pivot) > 0)
                {
                    countRight--;
                }
                if (countLeft <= countRight)
                {
                    var tmp = list[countLeft];
                    list[countLeft] = list[countRight];
                    list[countRight] = tmp;

                    countLeft++;
                    countRight--;
                }
            }
            if (left < countRight)
            {
                Sort(list, left, countRight);
            }
            if (countLeft < right)
            {
                Sort(list, countLeft, right);
            }
        }
    }
}