using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 2;
            int B = 4;
            int result = 1;
            for (int i = 0; i < B; i++)
            {
                result = result * A;

            }
            Console.WriteLine("Результат: " + result);



        }
    }
}
