using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    public class TicTacToeGame
    {
        public void StartTicTacToeGame()
        {
            Dictionary<int, char> number = new Dictionary<int, char>();

            number.Add(1, '_');
            number.Add(2, '_');
            number.Add(3, '_');
            number.Add(4, '_');
            number.Add(5, '_');
            number.Add(6, '_');
            number.Add(7, '_');
            number.Add(8, '_');
            number.Add(9, '_');

            Console.WriteLine($"  MAP{"\n"}|1|2|3|{"\n"}|4|5|6|{"\n"}|7|8|9|");

            Console.WriteLine("Enter a number from 1 to 9.");

            int counter = 0;
           
            for (int i = 1; i <= 9; i++) 
            {
                int index = int.Parse(Console.ReadLine());

                if (number[index] != '_')

                {
                    Console.WriteLine("Select another cell!");
                }

                else
                {
                    int stateIndex = counter % 2;
                    if (stateIndex == 0)
                    {
                        number[index] = 'X';
                        char name = number[index];
                        Console.WriteLine(name);
                    }

                    else
                    {
                        number[index] = 'O';
                        char name = number[index];
                        Console.WriteLine(name);
                    }
                    Console.WriteLine($"|{number[1]}|{number[2]}|{number[3]}|{"\n"}|{number[4]}|{number[5]}|{number[6]}|{"\n"}|{number[7]}|{number[8]}|{number[9]}|");

                    if ((number[1] == 'X' && number[1] == number[2] && number[2] == number[3]) ||
                         (number[4] == 'X' && number[4] == number[5] && number[5] == number[6]) ||
                         (number[7] == 'X' && number[7] == number[8] && number[8] == number[9]) ||
                         (number[1] == 'X' && number[1] == number[4] && number[4] == number[7]) ||
                         (number[2] == 'X' && number[2] == number[5] && number[5] == number[8]) ||
                         (number[3] == 'X' && number[3] == number[6] && number[6] == number[9]) ||
                         (number[1] == 'X' && number[1] == number[5] && number[5] == number[9]) ||
                         (number[3] == 'X' && number[3] == number[5] && number[5] == number[7]))
                    {
                        Console.WriteLine("First player wins! (X).");
                        break;

                    }
                    if ((number[1] == 'O' && number[1] == number[2] && number[2] == number[3]) ||
                        (number[4] == 'O' && number[4] == number[5] && number[5] == number[6]) ||
                        (number[7] == 'O' && number[7] == number[8] && number[8] == number[9]) ||
                        (number[1] == 'O' && number[1] == number[4] && number[4] == number[7]) ||
                        (number[2] == 'O' && number[2] == number[5] && number[5] == number[8]) ||
                        (number[3] == 'O' && number[3] == number[6] && number[6] == number[9]) ||
                        (number[1] == 'O' && number[1] == number[5] && number[5] == number[9]) ||
                        (number[3] == 'O' && number[3] == number[5] && number[5] == number[7]))
                    {
                        Console.WriteLine("Second player wins! (O).");
                        break;
                    }
                    Console.WriteLine("Enter number.");
                    counter++;
                }                
            }            
        }
    }
}