using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChallenges
{
    internal class Numbers
    {
        internal static int FindSecondLargestNumber(int[] numbers)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var ordered = numbers.OrderByDescending(y => y);
            Console.WriteLine("Second number OrderByDescending: " + ordered.Skip(1).First());

            int first = -1;
            int second = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (number > first)
                {
                    second = first;
                    first = number;
                }
                else if (number > second)
                {
                    second = number;
                }
            }
            Console.WriteLine("Second number: " + second);
            Console.ForegroundColor = ConsoleColor.White;

            return second;
        }
    }
}
