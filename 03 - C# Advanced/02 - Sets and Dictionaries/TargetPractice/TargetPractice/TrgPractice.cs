namespace TargetPractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TrgPractice
    {
        private static char[][] matrix = new char[1][];
        private static int impactRow = 0;
        private static int impactCol = 0;
        private static int radius = 0;
        private static Stack<char> temp = new Stack<char>();

        private static void InitMatrix(int n, int m)
        {
            matrix = new char[n][];
            var snake = Console.ReadLine();

            //generate the whole string that will fill our matrix
            var timesToRepeatText = Math.Ceiling((n * m) / (double)snake.Length);
            var text = string.Join("", Enumerable.Repeat(snake, (int)timesToRepeatText)).Reverse();
            var filling = new Stack<char>(text);
            int rowCounter = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                matrix[i] = new char[m];
                if (rowCounter % 2 == 1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i][j] = filling.Pop();
                    }
                }
                else
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        matrix[i][j] = filling.Pop();
                    }
                }
                rowCounter++;
            }
        }

        //private static bool CrossShooted(int r, int c)
        //{
        //    return (
        //        (r == impactRow && c == impactCol) ||
        //        (impactCol == c && impactRow - radius <= r && impactRow + radius >= r) ||
        //        (impactRow == r
        //                && impactCol - radius <= c
        //                && impactCol + radius >= c)
        //        );
        //}

        //private static bool DiagonalShooted(int r, int c)
        //{
        //    return (
        //        (CrossShooted(r + 1, c -1) && CrossShooted(r - 1, c + 1)) ||
        //         (CrossShooted(r + 1, c + 1) && CrossShooted(r - 1, c - 1)) ||
        //          (CrossShooted(r - 1, c + 1) && CrossShooted(r + 1, c - 1)) ||
        //           (CrossShooted(r - 1, c - 1) && CrossShooted(r + 1, c + 1))
        //        );
        //}

        static bool isCellShot(int row, int col, int shotRow, int shotCol, int shotRad)
        {
            return (col - shotCol) * (col - shotCol) + (row - shotRow) * (row - shotRow) <= shotRad * shotRad;
        }

        private static void Shoot(int n, int m)
        {
            var shotParams = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            impactRow = shotParams[0];
            impactCol = shotParams[1];
            radius = shotParams[2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(
                       // CrossShooted(i, j) || 
                       // DiagonalShooted(i, j)
                       isCellShot(i, j, impactRow, impactCol, radius)
                        )
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }
        }

        private static void FallDown(int n, int m)
        {             
            for (int j = 0; j < m; j++)// cols
            {
                
                for (int i = 0; i < n; i++)
			    {
                    if(matrix[i][j] != ' ')
                    {
                        temp.Push(matrix[i][j]);
                    }                    
                    matrix[i][j] = ' ';
			    }

                for (int i = n - 1; i >= 0; i--)
                {
                    if(temp.Count > 0)
                    {
                        matrix[i][j] = temp.Pop();
                    }else
                    {
                        break;
                    }                    
                }

                temp.Clear();
            }
        }

        private static void PrintResult(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var str = string.Join("", matrix[i]);
                Console.WriteLine(str);
            }
        }

        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = dimensions[0];//rows
            int m = dimensions[1];//columns

            InitMatrix(n, m);
            Shoot(n, m);
            FallDown(n, m);
            PrintResult(n);
        }
    }
}
