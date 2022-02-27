using System;
using System.Collections.Generic;
using System.Linq;

namespace separate_digits
{
    class Program
    {
        static List<int> SeparateNumber(int num)
        {
            var listOfDigits = new List<int>();
            int current = num;

            while (current !=0)
            {
                 listOfDigits.Add(current % 10);
                 current = current / 10;
            }

            return listOfDigits;
        }
        static void SeparateNumberLinq(int num)
        {
            var arr = num.ToString().Select(x => int.Parse(x.ToString()));

            foreach(var item in arr)
            {
                Console.WriteLine($"{item}");
            }
        }

        static void Main(string[] args)
        {
            var arr = SeparateNumber(12345);
            // foreach(var num in arr)
            // {
            //     Console.WriteLine($"{num}");
            // }

            SeparateNumberLinq(1234567890);
        }
    }
}
