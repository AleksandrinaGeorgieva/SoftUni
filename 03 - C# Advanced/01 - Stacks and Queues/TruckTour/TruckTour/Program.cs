using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long petrolInTank = 0;
            int startIndex = 0;
            int circleIndex = 0;
            string curEl, temp1;
            string[] currentPump;
            long currentAmount, distance;

            var data = new Queue<string>();
            
            for (int i = 0; i < N; i++)
            {
                data.Enqueue(Console.ReadLine());
            }
            var dataClone = new Queue<string>(data);
            
            while (circleIndex != N)
            {
                curEl = data.Dequeue();
                data.Enqueue(curEl);
                currentPump = curEl.Split(' ');
                currentAmount = long.Parse(currentPump[0]);
                distance = long.Parse(currentPump[1]);
                petrolInTank += currentAmount;
                if (petrolInTank < distance)
                {
                    startIndex++;
                    petrolInTank = 0;
                    temp1 = dataClone.Dequeue();
                    dataClone.Enqueue(temp1);
                    if(circleIndex != 0)
                    {
                        data = new Queue<string>(dataClone);
                    }
                    circleIndex = 0;
                }
                else
                {
                    circleIndex++;
                    petrolInTank -= distance;
                }            
            }
            Console.WriteLine(startIndex);
        }
    }
}
