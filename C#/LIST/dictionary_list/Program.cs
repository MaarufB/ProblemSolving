using System.Collections.Generic;
using System;

namespace dictionary_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, List<int>>();
            var myList = new List<int>();

            // add element to ur list
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // add list to the dictionary with the key val
            myDictionary.Add("ones", myList);
        }
    }
}
