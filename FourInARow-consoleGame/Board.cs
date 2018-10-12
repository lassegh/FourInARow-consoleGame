using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    
    public class Board
    {
        FourInARow game;
        public char[,] boardArray = new char[6, 6];

        public Board(FourInARow game)
        {
            this.game = game;
        }
        
        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char GetSingleValue(int x, int y)
        {
            return boardArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
        public void SetSingleValue(int x, int y, char value)
        {
            boardArray[x, y] = value;
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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < boardArray.Length; i++)
            {
                for (int j = 0; j < boardArray.Length; j++)
                {
                    sb.Append(GetSingleValue(i, j));
                }

                sb.Append("/n");
            }
            return base.ToString();
        }
    
    }
}
