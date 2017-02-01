using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class LessMemoryUsage
    {
        /* this is ugly structured code that receives max points from SoftUni Judge system, but is uglyyyyyy!!!! */
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split(' ');
            int number;
            while (input[0] != "print")
            {
                string command = input[0];

                switch (command)
                {
                    case "add":
                        int index = int.Parse(input[1]);
                        number = int.Parse(input[2]);
                        numbers.Insert(index, number);
                        break;
                    case "addMany":
                        var temp = input.ToList();
                        int und = int.Parse(temp[1]);
                        //remove the command and the index
                        temp.RemoveAt(0);
                        temp.RemoveAt(0);
                        var aa = temp.Select(int.Parse).ToList();
                        numbers.InsertRange(und, aa);

                        break;
                    case "contains":

                        number = int.Parse(input[1]);
                        Console.WriteLine(numbers.FindIndex(x => x == number));

                        break;
                    case "remove":
                        number = int.Parse(input[1]);
                        numbers.RemoveAt(number);
                        break;
                    case "shift":
                        int reps = int.Parse(input[1]);
                        for (int i = 0; i < reps; i++)
                        {
                            int n = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(n);
                        }
                        break;
                    case "sumPairs":
                        List<int> result = new List<int>();
                        for (int i = 0; i < numbers.Count; i += 2)
                        {
                            if (i + 1 < numbers.Count)
                            {
                                result.Add(numbers[i] + numbers[i + 1]);
                            }
                            else
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        numbers = result;

                        break;
                }
                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));

        }

    }
}
