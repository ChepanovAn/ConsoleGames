using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    public class GuessingGame
    {

        private readonly int max;
        private readonly int attempt;
        public GuessingGame(int max = 100, int attempt = 5)
        {
            this.max = max;
            this.attempt = attempt;
        }

        public void StartGessingGame()
        {
            int startNumber = -1;
            int countAttempt = 0;
            Random randNumber = new Random();
            int value = randNumber.Next(0, max);

            Console.WriteLine($"Enter a number from 0 to 100. You have only 5 attempts!");
            while (startNumber < value && countAttempt <= attempt)
            {

                string firstnumber = Console.ReadLine();

                bool result = int.TryParse(firstnumber, out int number);

                if (result == false)
                {
                    Console.WriteLine("Enter only a number.");
                }

                else if (number == value)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (number > value)
                {
                    Console.WriteLine("Your number is greater.");
                }
                else
                {
                    Console.WriteLine($"Your number is less.");
                }

                countAttempt++;
                if (countAttempt > attempt)
                {
                    Console.WriteLine($"You lost. Correct number {value}.");
                }
            }
        }       
        
    }
}
