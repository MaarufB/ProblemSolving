using System;
using System.Collections.Generic;


namespace check_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<int, string>();
            // add element to a dictionary
            myDictionary.Add(1, "one");
            myDictionary.Add(2,"two");
            myDictionary.Add(3, "three");
            myDictionary.Add(4, "four");
            myDictionary.Add(5, "five");

            if(myDictionary.ContainsKey(2))
            {
                Console.WriteLine($"Key found {myDictionary[2]}");
            }

        }
    }
}
