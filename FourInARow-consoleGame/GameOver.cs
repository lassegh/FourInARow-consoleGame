using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    public class GameOver
    {
        private static bool gameover = false;
        private static Char checkChar = '_';
        private static int counter = 0;

        /// <summary>
        /// Tjekker om der er 4 på stribe
        /// </summary>
        /// <param name="boardArray">Boarded som charArray</param>
        /// <returns>bool</returns>
        public static bool CheckFourInARow(Char[,] boardArray)
        {
            // Tjekker horisontalt
            CheckHorisontal(boardArray);
            
            // Tjekker vertikalt
            CheckVertical(boardArray);

            // Tjekker diagonalt
            for (int width = 0; width < 3; width++)
            {
                for (int height = 0; height < 3; height++)
                {
                    if (boardArray[height, width] != FourInARow.emptySpace &&
                        boardArray[height, width] == boardArray[height + 1, width + 1] &&
                        boardArray[height, width] == boardArray[height + 2, width + 2] &&
                        boardArray[height, width] == boardArray[height + 3, width + 3]) gameover = true;
                }

                for (int height = 3; height < 6; height++)
                {
                    if (boardArray[height,width] != FourInARow.emptySpace &&
                        boardArray[height, width] == boardArray[height-1, width+1] &&
                        boardArray[height, width] == boardArray[height-2, width+2] &&
                        boardArray[height, width] == boardArray[height-3, width+3]) gameover = true;
                }
            }
            return gameover;
        }

        /// <summary>
        /// Tjekker om der er fire på stribe horisontalt
        /// </summary>
        /// <param name="boardArray">Boarded</param>
        private static void CheckHorisontal(Char[,] boardArray)
        {
            for (int height = 0; height < 6; height++)
            {
                for (int width = 0; width < 6; width++)
                {
                    CheckEqualSpace(boardArray, height, width);
                }
                checkChar = '_';
                counter = 0;
            }
        }

        /// <summary>
        /// Tjekker om der er fire på stribe vertikalt
        /// </summary>
        /// <param name="boardArray">Boarded</param>
        private static void CheckVertical(Char[,] boardArray)
        {
            for (int width = 0; width < 6; width++)
            {
                for (int height = 0; height < 6; height++)
                {
                    CheckEqualSpace(boardArray, height, width);
                }

                checkChar = '_';
                counter = 0;
            }
        }

        /// <summary>
        /// Tjekker om nuværende space og spacet inden er ens
        /// </summary>
        /// <param name="boardArray">Boarded</param>
        /// <param name="height">Værdien på x-aksen</param>
        /// <param name="width">Værdien på y-aksen</param>
        private static void CheckEqualSpace(Char[,] boardArray, int height, int width)
        {
            if (boardArray[height, width] != FourInARow.emptySpace)
            {
                if (boardArray[height, width] == checkChar)
                {
                    counter++;
                    if (counter >= 4)
                    {
                        gameover = true;
                    }
                }
                else
                {
                    checkChar = boardArray[height, width];
                    counter = 1;
                }
            }
            else
            {
                checkChar = '_';
                counter = 0;
            }
        }
    }
}