using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    public class Player
    {
        private string playerName;
        private char formOfPiece;

        public Player(string name, char piece)
        {
            playerName = name;
            formOfPiece = piece;
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public char getFormOfPiece()
        {
            return formOfPiece;
        }

        public void PlayPiece()
        {
            // TODO Lav en Play Piece metode
        }


    }
}
