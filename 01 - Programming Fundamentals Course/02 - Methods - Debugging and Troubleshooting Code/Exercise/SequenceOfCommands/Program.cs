using System;
using System.Linq;
using System.Numerics;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());

        BigInteger[] numbers = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(BigInteger.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {            
           // string line = Console.ReadLine().Trim();
            int[] args = new int[2];
            string[] stringParams = command.Split(ArgumentsDelimiter);
            string action = stringParams[0];

            if (command.Contains("add") ||
                command.Contains("subtract") ||
                command.Contains("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                //numbers = PerformAction(numbers, action, args);
            }

            numbers = PerformAction(numbers, action, args);

            PrintArray(numbers);
           // Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static BigInteger[] PerformAction(BigInteger[] arr, string action, int[] args)
    {
        BigInteger[] array = arr.Clone() as BigInteger[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                array = ArrayShiftLeft(array);
                break;
            case "rshift":
                array = ArrayShiftRight(array);
                break;
        }
        return array;
    }

    private static BigInteger[] ArrayShiftRight(BigInteger[] array)
    {
        BigInteger temp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = temp;
        return array;
    }

    private static BigInteger[] ArrayShiftLeft(BigInteger[] array)
    {
        BigInteger temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length-1] = temp;
        return array;
    }

    private static void PrintArray(BigInteger[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
