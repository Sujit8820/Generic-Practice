using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Practice
{
    public class Generic
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            char[] charArray = {'a','b','c','d','e' };

            Generic.toPrint<int>(intArray);
            Generic.toPrint<double>(doubleArray);
            Generic.toPrint<char>(charArray);
;        }

        public static void toPrint<T>(T [] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("==================================================================");
        }

    }
}
