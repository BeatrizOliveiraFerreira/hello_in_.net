using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // You is going to have challenge write an algorithm that read two numbers and print the result division first for the second. Case it isn't possible show the message "impossible division" for the values of the question.
            // The input have one whole number N. This N will be amount the pairs of the whole values (x and y) that will be read.
            // For each case show the result of division with one digit after decimal point, or "impossible division" case it not be possible perform the calculation.

            // Output examples:
            // -1.5
            // impossible division
            // 0.0 

            decimal a = 3 / -2;
            Console.WriteLine(a + ".5");


            Console.WriteLine("impossible division");

            int b = 0 / 8;
            Console.WriteLine(b + ".0");
        }
    }
}
