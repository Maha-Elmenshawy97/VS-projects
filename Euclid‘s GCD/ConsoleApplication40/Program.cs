using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = GCD(x,y);
            Console.WriteLine("the gcd(m,n)={0}",z);
        }
        static int GCD(int m, int n)
        {
            while (n != 0)
            {
                int r = m % n;
                m = n;     n = r;
            }
            return m;
        }
    }
}
