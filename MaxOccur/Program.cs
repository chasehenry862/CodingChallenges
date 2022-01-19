using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Maxoccur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to find the most occuring character.");
            string value = Console.ReadLine();

            int ascii = 256;
            int[] count = new int[ascii];
            int length = value.Length;
            for (int i = 0; i < length; i++)
                count[value[i]]++;

            int max = -1;
            char result = ' ';

            for (int i = 0; i < length; i++)
            {
                if (max < count[value[i]])
                {
                    max = count[value[i]];
                    result = value[i];
                }
            }

            if (max == 1)
            {
                Console.WriteLine("No repitition");
            }
            else {
                 Console.WriteLine("Max occurring character is " +result);
            }
           
        }
    }
}
