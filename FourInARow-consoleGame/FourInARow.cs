using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{

    public class FourInARow
    {
        public Board board;
        public char emptySpace = 'O';
        private Player currentPlayer;

        public static char emptySpace = 'O';

        public FourInARow()
        {
            board = new Board(this);
            Player player1 = new Player("Lars", 'X');
            Player player2 = new Player("Martin", 'B');
            currentPlayer = Player.First();

            // TODO while loop, der kører hele spillet

            while (!GameOver.CheckFourInARow(board.boardArray))
            {
                // spørg currentplaye
                Console.ReadLine();

                player1.PlayPiece();

                // vis pladen

                // nextplayer()
            }
        }


        public void NextPlayer()
        {
            if (currentPlayer == Player.Last())
            {
                currentPlayer = Player.First();
            }
            else
            {
                int currentPlayerPosition = Player.IndexOf(currentPlayer);
                currentPlayer = Player[currentPlayerPosition + 1];
            }
        }
        // TODO next player
        
    }

    
}
