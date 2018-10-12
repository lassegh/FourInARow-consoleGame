using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    public class Board
    {
        char[,] twoDimensionalArray = new char[6, 6];

        public Board()
        {
            /// <summary>
            /// get a singel value from our two dimensional array
            /// </summary>
            /// <param name="x">x axis</param>
            /// <param name="y">y axis</param>
            /// <returns></returns>
            public char getSingleValue(int x, int y)
            {
                return twoDimensionalArray[x, y];
            }

            /// <summary>
            /// Set a single value our two dimensional array
            /// </summary>
            /// <param name="x">x axis position</param>
            /// <param name="y">y axis position</param>
            /// <param name="value">the char you want to set</param>
            /// <returns></returns>
            public char setSingleValue(int x, int y, char value)
            {
                twoDimensionalArray[x, y] = value;
            }

        }

        public void AddPiece(var formOfPiece, int kolonne)
        {

        }

        private bool BoardFull()
        {

        }

        public bool KolonneFull()
        {

        }
    }
    }
}
