using System;

namespace Suduko_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] puzzle = new int[9, 9]
            {
                {0,1,0,0,4,9,8,0,0 },
                {0,8,0,0,0,2,5,0,1 },
                {2,0,0,8,0,0,6,4,9 },
                {0,0,0,1,5,0,0,0,0 },
                {7,4,0,3,0,0,2,1,0 },
                {0,0,6,0,8,4,7,5,0 },
                {3,7,0,0,0,0,9,6,2 },
                {4,0,0,0,6,0,1,0,5 },
                {0,0,0,9,0,8,0,7,4 }
            };

            int[,] changeable = new int[9, 9];
            for (int countY = 0; countY < 9; countY++)
            {
                for (int countX = 0; countX < 9; countX++)
                {
                    if (puzzle[countY, countX] != 0)
                    {
                        changeable[countY, countX] = 1;
                    }
                    else
                    {
                        changeable[countY, countX] = 0;
                    }
                }
            }

            Puzzle p = new Puzzle();
            Algorithm Algo = new Algorithm();

            p.display(puzzle);

            bool valdation = p.validation(puzzle);
            Console.WriteLine(valdation);
            System.Threading.Thread.Sleep(100);


            for (int countY = 0; countY < 9; countY++)
            {
                for (int countX = 0; countX < 9; countX++)
                {
                    if (changeable[countY, countX] == 0)
                    {
                        puzzle[countY, countX]++;

                        //p.display(puzzle);

                        valdation = p.validation(puzzle);
                        //Console.WriteLine(valdation);

                        //System.Threading.Thread.Sleep(25);

                        while (valdation == false)
                        {                                                      
                            puzzle[countY, countX]++;
                            valdation = p.validation(puzzle);
                            //p.display(puzzle);
                            //Console.WriteLine(valdation);
                            //System.Threading.Thread.Sleep(25);

                            if (puzzle[countY, countX] > 9)
                            {
                                puzzle[countY, countX] = 0;
                                countX--;

                                if (countX < 0)
                                {
                                    countX = 8;
                                    countY--;
                                }

                                while (changeable[countY, countX] == 1)
                                {
                                    countX--;
                                    if (countX < 0)
                                    {
                                        countX = 8;
                                        countY--;
                                    }
                                }
                                countX--;
                                valdation = true;
                               
                            }
                        }
                    }
                }
            }

            p.display(puzzle);
            Console.ReadLine();
        }
    }
}
