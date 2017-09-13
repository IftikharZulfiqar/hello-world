using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i = i + 2)
            {
                for (int k = 9; k >= i; k = k - 2)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");

                }

                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}