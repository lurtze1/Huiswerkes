using System;
using Oefentoets_Design_Patterns.Encryption.Concretes;

namespace Oefentoets_Design_Patterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var math = Wiskunde.Wiskunde.GetInstance();
            float x = 5;
            float y = 7;

            float result = math.Divide(x, y);
            Console.WriteLine(result);
            result = math.Multiply(result, 2);
            Console.WriteLine(result);
            result = math.Subtract(result, 4);
            Console.WriteLine(result);
            result = math.Sum(result, x);

            var noEncryption = new NoEncryption();
            var reverseEncryption = new ReverseEncryption();
            var shiftEncryption = new ShiftEncryption();

            string test = "Time flies like an arrow, fruit flies like a banana.";

            Console.WriteLine(noEncryption.PreformEncryption(test));
            Console.WriteLine(reverseEncryption.PreformEncryption(test));
            Console.WriteLine(shiftEncryption.PreformEncryption(test));
        }
    }
}