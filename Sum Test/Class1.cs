﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to sum?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int [n];
            Console.WriteLine("Please enter the numbers you would like to sum?");
            for (int i=0; i<n; i++)
            {
               array[i]=int.Parse(Console.ReadLine());
            }

            int summ = 0;
            foreach (int value in array)
            {
                summ += value;

            }
            ArrayUtils obj = new ArrayUtils();
        Console.Write("The sum is calculated to be {0} in Class Test and {1} in Class ArrayUtils. Hence, ", summ, obj.sum(array));
            if (summ == obj.sum(array))
            {
                Console.WriteLine("the sum are equal in both classes.");
            }
            else
                Console.WriteLine("the sum of the two class are not equal.");

        }
    }

}
