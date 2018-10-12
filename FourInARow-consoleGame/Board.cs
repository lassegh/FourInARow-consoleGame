using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    public class Board
    {
        public char[,] twoDimensionalArray = new char[6, 6];

        public Board()
        {

        }

        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char GetSingleValue(int x, int y)
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
        public char SetSingleValue(int x, int y, char value)
        {
            twoDimensionalArray[x, y] = value;
        }

        public void AddPiece(char formOfPiece, int kolonne)
        {
            // TODO tjekke om kolonnen er fuld, hvis NEJ tilføj til rigtig kolonne
        }

        private bool BoardFull()
        {
            return BoardFull;
        }

        public bool KolonneFull()
        {
            return KolonneFull;
        }

        public override string ToString()
        {
            // TODO DrawBoard
            return base.ToString();
        }
    
    }
}
