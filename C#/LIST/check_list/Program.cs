using System;
using System.Collections.Generic;

namespace check_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>()
            {
                "ma-aruf",
                "burad",
                "mohammad",
                "pagayawan"
            };

            var len = myList.Count;
            Console.WriteLine(len);

            if(myList.Contains("ma-aruf"))
            {
                Console.WriteLine("Ma-aruf is present");
                var index = myList.FindIndex(i => i.Contains("ma-aruf"));
                Console.WriteLine($"Ma-aruf is at index:{index} {myList[index]}");
            }
        }
    }
}
