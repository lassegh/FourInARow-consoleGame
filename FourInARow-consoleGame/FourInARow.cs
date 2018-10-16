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

            currentPlayer = players.First(); // Bør currentPlayer ikke først initialiseres med en af spillerne EFTER de er oprettet?
            players.Add(new Player("Lars", 'X'));
            players.Add(new Player("Martin", 'B'));



            while (!GameOver.CheckFourInARow(board.boardArray)) // Hvorfor køres loopet i constructoren?
            {
                
                if (!board.BoardFull()) // nu tjekker vi i stedet om boardet er fuldt -lars
                {

                    // spørg currentplayer
                    Console.WriteLine(currentPlayer.getPlayerName() + "Hvilken brik + kolonne vil du spille? Du kan vælge mellem 1-6"); // Player har ingen tostring, så her vil det være en idé at kalde currentPlayer.GetPlayerName() //rettet -lars

                    // var playerPick = Console.ReadLine(board.AddPiece(char formOfPiece, int kolonne));
                    board.AddPiece(currentPlayer.getFormOfPiece(), Int32.Parse(Console.ReadLine())-1); // Er første attribut ikke currentPlayer.GetFormOfPiece() ? Mens anden attribut er Console.Readline() ? //rettet - lars
                }
                else //altså, hvis brættet er fuldt
                {
                    Console.WriteLine("Jamen så er spillet slut. Det blev en uafgjort!");
                    break; //afslutter loopet - lars
                }

                // print pladen
                Console.WriteLine(board.boardArray); // Jeg mener Lars lavede en toString så vi bare kan udskrive objectet...

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
