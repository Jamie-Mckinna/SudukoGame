using System;

namespace Suduko_Game
{
    class Program
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
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
