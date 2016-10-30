using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Opdracht_1
    {
        public static void printLetters(int n)
        {
            if (n > 0)
            {
                Console.Write("A");
                printLetters(--n);
                Console.Write("Z");
            }
        }

        public static void printLetters2(int p, int q)
        {
            if (q > 0)
            {
                if (p > 0)
                {
                    Console.Write("A");

                    --p;
                }
                if (p <= 0)
                {
                    Console.Write("Z");
                    --q;
                }
                printLetters2(p, q);
            }
        }
    }
}