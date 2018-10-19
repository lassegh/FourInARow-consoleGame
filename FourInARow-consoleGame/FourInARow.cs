using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{

    public class FourInARow
    {
        List<Player> players = new List<Player>();
        public Board board;
        public Player currentPlayer;
       

        public static char emptySpace = 'O';

        public FourInARow()
        {
            board = new Board(this);

            
            players.Add(new Player("Lars", 'X'));
            players.Add(new Player("Martin", 'B'));
            currentPlayer = players.First();

            //gameloop
            while (!GameOver.CheckFourInARow(board.boardArray))
            {
                //printer pladen
                Console.WriteLine(board);

                if (!board.BoardFull()) //tjekker om boardet er fuldt
                {
                    //spørg currentplayer hvilken brik de vil spille
                    Console.WriteLine(currentPlayer.getPlayerName() +
                                      " \nHvilken brik + kolonne vil du spille? Du kan vælge mellem 1-6");

                    board.AddPiece(currentPlayer.getFormOfPiece(),
                        Convert.ToInt32(Console.ReadLine()) - 1); //Add'er brik til kolonne
                }
                else //hvis brættet er fuldt
                {
                    Console.WriteLine("Brættet er fuldt. Det blev uafgjort!");
                    break; //afslutter loopet
                }
                Console.Clear();



                //næste spillers tur
                if (!GameOver.CheckFourInARow(board.boardArray))
                {
                    NextPlayer();
                }
                else
                {
                    Console.WriteLine(currentPlayer.getPlayerName() + " har vundet spillet!");
                    break; //afslutter loopet
                }
            }
        }

        public void NextPlayer()
        {
            if (currentPlayer == players.Last())
            {
                currentPlayer = players.First();
            }
            else
            {
                int currentPlayerPosition = players.IndexOf(currentPlayer);
                currentPlayer = players[currentPlayerPosition + 1];
            }
        }
        
    }

    
}
