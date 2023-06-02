using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }



        }


        
    }
}
