using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //var test = Enumerable.Repeat(int.MinValue, numbers.Length).ToArray();

            int[] values = new int[numbers.Length];
            int[] amount = new int[numbers.Length];
            int valueIndexToPush = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = Array.IndexOf(values, numbers[i]);
                if (index > -1)
                {
                    amount[index]++;
                }
                else
                {
                    values[valueIndexToPush] = numbers[i];
                    amount[valueIndexToPush] = 1;
                    
                }
                valueIndexToPush++;
            }

            int max = amount.Max();
            int indexOfMax = Array.IndexOf(amount, max);

            Console.WriteLine(values[indexOfMax]);
        }
    }
}
