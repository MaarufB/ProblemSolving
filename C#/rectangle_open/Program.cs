using System;

namespace rectangle_open
{
    class Program
    {
        static void DrawRectangle(int length)
        {
            int head = 1;
            int foot = length;
            for(int i=1; i<=length; i++)
            {
                if(i==head || i==foot)
                {
                    for(int j=1; j<=length; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for(int k=1; k<=length; k++)
                    {
                        if (k==head || k==foot)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawRectangle(5);
        }
    }
}
