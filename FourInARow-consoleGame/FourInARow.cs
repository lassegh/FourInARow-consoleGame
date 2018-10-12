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

        public FourInARow()
        {
            board = new Board(this);
            Player player1 = new Player("Lars", 'X');
            Player player2 = new Player("Martin", 'B');
        }

        // TODO while loop, der kører hele spillet

        // TODO next player
        
    }

    
}
