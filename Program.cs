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

            Generic.toPrint(intArray);
            Generic.toPrint(doubleArray);
            Generic.toPrint(charArray);
;        }

        public static void toPrint(int [] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
