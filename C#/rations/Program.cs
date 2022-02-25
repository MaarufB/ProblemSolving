using System;
using System.Collections.Generic;


namespace rations
{
    class Program
    {
        static void PrintRatio(List<int> arr)
        {
            var ratioDictionary = new Dictionary<string, int>();
            ratioDictionary.Add("positive",0);
            ratioDictionary.Add("negative", 0);
            ratioDictionary.Add("zero", 0);

            int ratioLength = arr.Count;
            Console.WriteLine($"Length: {ratioLength}");

            foreach(var num in arr)
            {
                if (num>0)
                {
                    int new_val = ratioDictionary["positive"] + 1;
                    ratioDictionary["positive"] = new_val;
                    Console.WriteLine(new_val.ToString());
                }
                    
                else if(num <0)
                {
                    int new_val = ratioDictionary["negative"] + 1;
                    ratioDictionary["negative"] = new_val;
                }
                    
                else
                {
                    int new_val = ratioDictionary["zero"] += 1;
                    ratioDictionary["zero"] = new_val;
                }
                    
            }

            foreach(var key in ratioDictionary.Keys)
            {
                var ratio = (ratioDictionary[key] * 1000000)/ ratioLength;
                var newResult = 100/ratio;
                Console.WriteLine(newResult.ToString());
            }



        }

        static void Main(string[] args)
        {
            var inputs = new List<int>();

            inputs.Add(-1);
            inputs.Add(2);
            inputs.Add(0);
            inputs.Add(0);
            inputs.Add(-5);
            inputs.Add(2);
            PrintRatio(inputs);
        }
    }
}
