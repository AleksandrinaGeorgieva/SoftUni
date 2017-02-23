using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceRatings = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPriceRatings = Console.ReadLine();

            //calculate left damage
            //calculate right damage
            //print higher damage
            //if equal  - print left

            //cheap - lower than the entry price
            // ecpensive - same or higher price than the entry point

            //positive - above 0
            // negative - below 0 
            // all - any 

            BigInteger leftSum = 0;
            BigInteger rightSum = 0;
            var leftList = new List<long>();
            var rightList = new List<long>();

            if(typeOfItems == "cheap")
            {
                if(typeOfPriceRatings == "positive")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if(priceRatings[i] > 0 && priceRatings[i] < priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] < priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
                if (typeOfPriceRatings == "negative")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
                if (typeOfPriceRatings == "all")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
            }
            else
            {
                if (typeOfPriceRatings == "positive")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
                if (typeOfPriceRatings == "negative")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] >= priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] < 0 && priceRatings[i] >= priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
                if (typeOfPriceRatings == "all")
                {
                    //left
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            leftList.Add(priceRatings[i]);
                        }
                    }

                    //right
                    for (long i = entryPoint + 1; i < priceRatings.Length; i++)
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            rightList.Add(priceRatings[i]);
                        }
                    }
                }
            }

            leftSum = leftList.Sum();
            rightSum = rightList.Sum();

            if(leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
