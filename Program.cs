using System;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
