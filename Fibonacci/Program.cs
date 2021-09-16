using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Algorithms algo = new Algorithms();

            int n = 10;
            var ret = algo.GenerateFib(n);

            if(ret!=null && ret.Length > 0)
            {
                for (int i = 0; i < ret.Length; i++)
                {
                    Console.WriteLine(ret[i]);
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
