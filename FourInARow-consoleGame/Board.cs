using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

            for (int i = 0; i < boardArray.Length; i++)
            {
                for (int j = 0; j < boardArray.Length; j++)
                {
                    SetSingleValue(i, j, FourInARow.emptySpace);
                }
                
            }
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

        public bool AddPiece(char formOfPiece, int kolonne)
        {
            if (KolonneFull(kolonne))
            {
                return true;
            }
            else
            {
                SetSingleValue(kolonne, KolonnePlacement(kolonne), formOfPiece);
                return false;
            }

  
        }

        public bool BoardFull()
        {
            //tjekker alle kolonner. hvis alle returnerer -1, så er alle kolonner fulde, derfor er brættet fuldt
            for (int i = 0; i < 5 ; i++)
            {
                if(KolonneFull(i))
                {
                    return false;
                }
            }

            return true;
        }


        public bool KolonneFull(int kolonne)
        {
            if (boardArray[kolonne, 0] == FourInARow.emptySpace)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public int KolonnePlacement(int kolonne)
        {
            for (int i = 5; i > 0;)
            {
                if (boardArray[kolonne, i] == FourInARow.emptySpace)
                {
                    return i;
                }
                else
                {
                    i--;
                }
            }

            return -1; //-1, nu en standard error code

        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < boardArray.Length; i++)
            {
                for (int j = 0; j < boardArray.Length; j++) { sb.Append(FourInARow.emptySpace);}
                sb.Append("/n");
            }
            return base.ToString();
        }
    
    }
}
