using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    public class GameOver
    {
        /// <summary>
        /// Tjekker om der er 4 på stribe
        /// </summary>
        /// <param name="boardArray">Boarded som charArray</param>
        /// <returns>bool</returns>
        public static bool CheckFourInARow(Char[,] boardArray)
        {
            Boolean gameover = false;
            Char checkChar = '_';
            int counter = 0;

            // Tjekker horisontalt
            for (int height = 0; height < 6; height++)
            {
                for (int width = 0; width < 6; width++)
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

                checkChar = '_';
                counter = 0;
            }
<<<<<<< HEAD
            
            bool gameover = false;
             
=======

            // Tjekker vertikalt
            for (int width = 0; width < 6; width++)
            {
                for (int height = 0; height < 6; height++)
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

                checkChar = '_';
                counter = 0;
            }

            // Tjekker diagonalt \
            for (int width = 0; width < 3; width++)
            {
                for (int height = 0; height < 3; height++)
                {
                    if (boardArray[height, width] != FourInARow.emptySpace &&
                        boardArray[height, width] == boardArray[height + 1, width + 1] &&
                        boardArray[height, width] == boardArray[height + 2, width + 2] &&
                        boardArray[height, width] == boardArray[height + 3, width + 3])
                    {
                        gameover = true;
                    }

                }

                for (int height = 3; height < 6; height++)
                {
                    if (boardArray[height,width] != FourInARow.emptySpace &&
                        boardArray[height, width] == boardArray[height-1, width+1] &&
                        boardArray[height, width] == boardArray[height-2, width+2] &&
                        boardArray[height, width] == boardArray[height-3, width+3])
                    {
                        gameover = true;
                    }
                }

            }


            // Tjekker diagoanlt /

>>>>>>> f35c5e6739259af55694a9680db689fda8dcfe48
            return gameover;
        }
    }
}


