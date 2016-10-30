using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1 {
    class Program {
        static void Main(string[] args) {
            // 1a
            Console.WriteLine(printLetters(3));
            Console.WriteLine(printLetters(0));

            // 1b
            Console.WriteLine(printLetters2(3, 5));
            Console.WriteLine(printLetters2(2, 0));

            Console.Read();
        }

        static string printLetters(int n, string letters = "") {
            if (n > 0) {
                letters = "A" + letters;
                letters += "Z";
                n--;
                return printLetters(n, letters);
            }
            return letters;
        }

        static string printLetters2(int p, int q, string letters = "") {
            if (p > 0) {
                letters = "A" + letters;
                p--;
                return printLetters2(p, q, letters);
            } else if (q > 0) {
                letters += "Z";
                q--;
                return printLetters2(p, q, letters);
            }
            return letters;
        }
    }
}
