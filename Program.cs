using System;

namespace ConsoleGames
{
    class Program
    {         

        static void Main(string[] args)
        {
            Console.WriteLine("Select Game: \n Number 1 - GuessingGame \n Number 2 - TicTacToeGame");
            string GameNumber=Console.ReadLine();        
            
            do
            {
                if (GameNumber == "1")
                {
                    GuessingGame firstGame = new GuessingGame();
                    firstGame.StartGessingGame();

                    Console.WriteLine("Select Game: \n Number 1 - GuessingGame \n Number 2 - TicTacToeGame");
                    GameNumber = Console.ReadLine();
                }
                else if (GameNumber == "2")
                {
                    TicTacToeGame secondGame = new TicTacToeGame();
                    secondGame.StartTicTacToeGame();

                    Console.WriteLine("Select Game: \n Number 1 - GuessingGame \n Number 2 - TicTacToeGame");
                    GameNumber = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Choose the correct game number");
                    GameNumber = Console.ReadLine();
                }
            }            
            while (GameNumber != "1" || GameNumber != "2");         

        }
    }    
}
