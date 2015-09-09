using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler92
{
    class Program
    {
        static void Main(string[] args)
        {
            int count89 = 0;
            for(int i = 1; i < 10000000; i++)
            {
                if (SumSquareOfDigitsUntilLoop(i) == 89)
                    count89++;
            }
            Console.WriteLine(count89);
            Console.ReadLine();
        }

        static int SumSquareOfDigitsUntilLoop(int n)
        {
            int next = n;
            while (next != 1 && next != 89)
            {
                n = next;
                next = 0;
                while (n > 0)
                {
                    int i = n % 10;
                    next += i * i;
                    n = n / 10;
                }
            }
            return next;
        }
    }
}
