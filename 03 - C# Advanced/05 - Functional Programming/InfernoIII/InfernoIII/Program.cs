using System;
using System.Collections.Generic;
using System.Linq;

namespace InfernoIII
{
    class Program
    {
        private static Dictionary<string, Func<int, int, bool>> predicates = new Dictionary<string, Func<int, int, bool>> {
            { "Sum Left", SumLeft },
            { "Sum Right", SumRight },
            { "Sum Left Right", SumLeftRight }
        };

        private static List<int> gems = new List<int>();

        private static bool SumLeft(int index, int condition)
        {
            var leftGemPower = index > 0 ? gems[index - 1] : 0;
            return (leftGemPower + gems[index] == condition);
        }

        private static bool SumRight(int index, int condition)
        {
            var rightGemPower = index + 1 < gems.Count ? gems[index + 1] : 0;
            return (rightGemPower + gems[index] == condition);
        }

        private static bool SumLeftRight(int index, int condition)
        {
            var leftGemPower = index > 0 ? gems[index - 1] : 0;
            var rightGemPower = index + 1 < gems.Count ? gems[index + 1] : 0;
            return (rightGemPower + leftGemPower + gems[index] == condition);
        }

        static void Main(string[] args)
        {
            gems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var actions = new List<string>();

            var command = Console.ReadLine();

            while(command.ToLower() != "forge")
            {
                var splitted = command.Split(';');
                var action = $"{splitted[1]};{splitted[2]}";

                if (splitted[0] == "Exclude")
                {
                    actions.Add(action);
                }else
                {
                    if (actions.Contains(action))
                    {
                        actions.Remove(action);
                    }
                }

                command = Console.ReadLine();
            }

            var toRemove = new List<int>();
            for (int i = 0; i < actions.Count; i++)
            {
                var currentAction = actions[i].Split(';');
                var tr = gems.Where((x, index) => predicates[currentAction[0]](index, int.Parse(currentAction[1])))
                    .ToList();
                toRemove.AddRange(tr);
            }

            for (int i = 0; i < toRemove.Count; i++)
            {
                gems.Remove(toRemove[i]);
            }

            gems.ForEach(x => Console.Write($"{x} "));
        }
    }
}
