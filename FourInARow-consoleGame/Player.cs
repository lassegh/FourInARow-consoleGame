using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Player
    {
        private string playerName;
        private char formOfPiece;

        public Player(string name, char piece)
        {
            playerName = name;
            formOfPiece = piece;
        }

        public void playPiece()
        {
            //TODO: Lav metoden
        }


        public string getPlayerName()
        {
            return playerName;
        }

        public char getFormOfPiece()
        {
            return formOfPiece;
        }




    }
}
