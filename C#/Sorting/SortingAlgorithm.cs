using System.Collections.Generic;

namespace Sorting
{
    public class SortingAlgorithm
    {
        public void BubbleSort(List<int> sequence)
        {
            bool isSorted = false;
            

            while(!isSorted)
            {
                isSorted = true;
                for(int i = 0; i <sequence.Count - 1; i++)
                {
                    if(sequence[i] > sequence[i+1])
                    {
                        isSorted = false;

                        var current = sequence[i];
                        sequence[i] = sequence[i+1];
                        sequence[i+1] = current;
                    }
                }
            }

            foreach(var item in sequence)
            {
                Console.Write($"{item} ");
            }
        }

        
    }
}
