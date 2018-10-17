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


            while (!GameOver.CheckFourInARow(board.boardArray))
            {
                
                if (!board.BoardFull()) // nu tjekker vi i stedet om boardet er fuldt -lars
                {
                    // spørg currentplayer hvilken brik de vil spille
                    Console.WriteLine(currentPlayer.getPlayerName() + "Hvilken brik + kolonne vil du spille? Du kan vælge mellem 1-6");

                    board.AddPiece(currentPlayer.getFormOfPiece(), Convert.ToInt32(Console.ReadLine())-1); //Add'er brik til kolonne
                }
                else //hvis brættet er fuldt
                {
                    Console.WriteLine("Brættet er fuldt. Det blev uafgjort!");
                    break; //afslutter loopet
                }

                // print pladen
                Console.WriteLine(board.boardArray);

                // Inden nextplayer kaldes tænker jeg GameOver klassen skal kaldes evt gennem et if statement


                // nextplayer()
                NextPlayer();
                Console.WriteLine("Nu er det " + currentPlayer + "'s tur");
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
