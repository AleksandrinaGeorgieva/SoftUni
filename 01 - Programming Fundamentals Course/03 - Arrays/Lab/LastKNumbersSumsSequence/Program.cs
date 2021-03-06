﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int len = i - k;
                len = len < 0 ? 0 : len;
                for (int j = array.Length-1; j >= len; j--)
                {
                    sum += array[j];
                }

                array[i] = sum;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}