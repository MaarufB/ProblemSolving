using System;

namespace triangle
{
    class Program
    {
        static void DrawTriangle(int num)
        {
            
            for(int i=1; i<=num; i++)
            {
                // Make a space
                for(int j=1; j<=num-i; j++)
                {
                    Console.Write(" ");
                }
                
                // Print asterisk
                for(int k=1; k<=i; k++)
                {
                    Console.Write($"{i}");
                }
                Console.Write("\n");


            }
        }
        static void Main(string[] args)
        {
            DrawTriangle(5);
        }
    }
}
