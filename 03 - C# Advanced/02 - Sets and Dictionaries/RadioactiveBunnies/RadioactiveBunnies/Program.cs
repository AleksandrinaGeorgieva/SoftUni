namespace RadioactiveBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static int n;
        private static int m;
        private static char[][] matrix = new char[1][];
        private static HashSet<Position> bunnies = new HashSet<Position>();
        private static Position playerPosition = new Position();

        private static void FillLair()
        {
            matrix = new char[n][];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .ToCharArray();
                matrix[i] = input;
            }
        }

        public static void FillData()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        bunnies.Add(new Position
                        {
                            row = i,
                            col = j
                        });
                    }
                    else if (matrix[i][j] == 'P')
                    {
                        playerPosition.row = i;
                        playerPosition.col = j;
                    }
                }
            }
        }

        public static void DrawFinalLair()
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Enumerable.Repeat('.', m).ToArray();
            }
            foreach (var b in bunnies)
            {
                matrix[b.row][b.col] = 'B';
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }

        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            n = dimensions[0];
            m = dimensions[1];

            FillLair();
            FillData();

            var directions = Console.ReadLine()
                .ToCharArray();

            var nextmove = new Position
            {
                row = playerPosition.row,
                col = playerPosition.col
            };

            bool dead = false;
            bool escaped = false;

            //player makes a move
            for (int move = 0; move < directions.Length; move++)
            {
                switch (directions[move])
                {
                    case 'U':
                        nextmove.row--;
                        break;
                    case 'D':
                        nextmove.row++;
                        break;                        
                    case 'L':
                        nextmove.col--;
                        break;
                    case 'R':
                        nextmove.col++;
                        break;
                }

                if(nextmove.col < 0 || nextmove.col == m
                    || nextmove.row < 0 || nextmove.row == n)
                {
                    // player is out of the lair
                    escaped = true;
                }
                else if(
                    
                    matrix[nextmove.row][nextmove.col] == 'B')
                {
                    dead = true;
                }

                //get new bunnies then merge it with the other ones
                var newBunnies = new HashSet<Position>();
                foreach (var bunny in bunnies)
                {   //up
                    if(bunny.row > 0)
                    {
                        newBunnies.Add(new Position
                        {
                            row = bunny.row - 1,
                            col = bunny.col
                        });
                    }
                    
                    if(bunny.row + 1 < n)
                    {
                        //down
                        newBunnies.Add(new Position
                        {
                            row = bunny.row + 1,
                            col = bunny.col
                        });
                    }
                    
                    if(bunny.col > 0)
                    {
                        //left
                        newBunnies.Add(new Position
                        {
                            row = bunny.row,
                            col = bunny.col - 1
                        });
                    }
                    
                    if(bunny.col + 1 < m)
                    {
                        //right
                        newBunnies.Add(new Position
                        {
                            row = bunny.row,
                            col = bunny.col + 1
                        });
                    }
                   
                }

                if (newBunnies.Contains(nextmove))
                {
                    dead = true;
                }
                bunnies = new HashSet<Position>(bunnies.Union(newBunnies));

                //while???
                
                if (dead || escaped)
                {
                    break;
                }
                playerPosition.row = nextmove.row;
                playerPosition.col = nextmove.col;
            }

            DrawFinalLair();            

            if (dead)
            {
                Console.WriteLine($"dead: {nextmove.row} {nextmove.col}");
            }else
            {
                Console.WriteLine($"won: {playerPosition.row} {playerPosition.col}");
            }
        }
    }
}
