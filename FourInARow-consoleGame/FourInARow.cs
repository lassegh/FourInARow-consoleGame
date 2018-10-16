using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{

    public class FourInARow
    {
        List<Player> players = new List<Player>();
        public Board board;
        public char emptySpace = 'O';
        public Player currentPlayer;
       

        public static char emptySpace = 'O';

        public FourInARow()
        {
            board = new Board(this);

            currentPlayer = players.First();
            players.Add(new Player("Lars", 'X'));
            players.Add(new Player("Martin", 'B'));


            while (!GameOver.CheckFourInARow(board.boardArray))
            {
                // spørg currentplaye
                if (!board.KolonneFull(kolonne))
                {
                    Console.WriteLine(currentPlayer + "Hvilken brik + kolonne vil du spille? Du kan vælge mellem 1-6");

                    // var playerPick = Console.ReadLine(board.AddPiece(char formOfPiece, int kolonne));
                    board.AddPiece(char formOfPiece, int kolonne);
                }

                // print pladen
                Console.WriteLine(board.boardArray);

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
