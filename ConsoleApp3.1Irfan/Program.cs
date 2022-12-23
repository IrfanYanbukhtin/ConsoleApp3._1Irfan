using System;

namespace ConsoleApp3._1Irfan
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1000000)
                {
                if (i % 3 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
