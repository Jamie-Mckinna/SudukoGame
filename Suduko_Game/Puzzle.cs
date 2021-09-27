using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suduko_Game
{
    class Puzzle
    {
        public void display(int[,] puzzle)
        {
            Console.Clear();
            for (int countY = 0; countY < 9; countY++)
            {
                if((countY % 3) == 0 && countY != 0)
                {
                    Console.Write("-----------------------------\n");
                }
                for (int countX = 0;  countX < 9; countX++)
                {
                    if ((countX % 3) == 0 && countX != 0)
                    {
                        Console.Write("|");
                    }

                    if (puzzle[countY, countX] == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" {0} ", puzzle[countY, countX]);
                    }
                }
                Console.Write("\n");
            }
        }
        public bool validation(int[,] puzzleArray)
        {
            for (int countY = 0; countY < 9; countY++)
            {
                for (int countX = 0; countX < 9; countX++)
                {
                    if (puzzleArray[countY, countX] > 9)
                    {
                        return false;
                    }
                }
            }

            //Check for validation across the puzzle
            for (int countY = 0; countY < 9; countY++)
            {
                int[] rowCheck = new int[10];
                for (int countX = 0; countX < 9; countX++)
                {
                    int number = puzzleArray[countY, countX];
                    if (number != 0)
                    {
                        rowCheck[number]++;
                    }
                    else
                    {
                        rowCheck[number] = 0;
                    }

                    if(rowCheck[number] > 1)
                    {
                        return false;
                    }
                }
            }

            //Check for validation down the puzzle
            for (int countX = 0; countX < 9; countX++)
            {
                int[] rowCheck = new int[10];
                for (int countY = 0; countY < 9; countY++)
                {
                    int number = puzzleArray[countY, countX];
                    if (number != 0)
                    {
                        rowCheck[number]++;
                    }
                    else
                    {
                        rowCheck[number] = 0;
                    }

                    if (rowCheck[number] > 1)
                    {
                        return false;
                    }
                }
            }

            //3x3 cube validation
            for (int cubeY = 0; cubeY < 3; cubeY++)
            {
                for (int cubeX = 0; cubeX < 3; cubeX++)
                {
                    int[] rowCheck = new int[10];
                    for (int countY = 0; countY < 3; countY++)
                    {
                        for (int countX = 0; countX < 3; countX++)
                        {
                            int colY = countY + (cubeY * 3);
                            int colX = countX + (cubeX * 3);
                            int number = puzzleArray[colY, colX];

                            if (number != 0)
                            {
                                rowCheck[number]++;
                            }
                            else
                            {
                                rowCheck[number] = 0;
                            }

                            if (rowCheck[number] > 1)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
