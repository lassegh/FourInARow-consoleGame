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
                    SetSingleValue(i, j, game.emptySpace);
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

        public void AddPiece(char formOfPiece, int kolonne)
        {
            // TODO tjekke om kolonnen er fuld, hvis NEJ tilføj til rigtig kolonne

            //bed om en int for kolonnefull
            if (KolonneFull(kolonne) == -1)
            {
                Console.WriteLine("Kolonnen er fuld");
            }
            
            SetSingleValue(kolonne, KolonneFull(kolonne), formOfPiece);
        }

        public bool BoardFull()
        {
            //tjekker alle kolonner. hvis alle returnerer -1, så er alle kolonner fulde, derfor er brættet fuldt
            for (int i = 0; i < 5 ; i++)
            {
                if(KolonneFull(i) != -1)
                {
                    return false;
                }
            }

            return true;
        }

        public int KolonneFull(int kolonne)
        {
            for (int i = 6; i > 0; i--)
            {
                if (boardArray[kolonne, i] == game.emptySpace)
                {
                    return i; //return pladsen tilbage til at spille brikken
                }

                else return -1; //returner at kolonnen er fuld
            }

            return -1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < boardArray.Length; i++)
            {
                for (int j = 0; j < boardArray.Length; j++) { sb.Append(game.emptySpace);}
                sb.Append("/n");
            }
            return base.ToString();
        }
    
    }
}
