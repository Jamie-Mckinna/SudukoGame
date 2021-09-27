using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suduko_Game
{
    class Algorithm
    {
        public void BacktrackAlgo(int[,] puzzleArray)
        {
            for (int countY = 0; countY < 9; countY++)
            {
                for (int countX = 0; countX < 9; countX++)
                {
                    if (puzzleArray[countY, countX] == 0)
                    {

                    }
                }
            }
        }
    }
}
