using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class program
    {
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        public const int WINPOSITION = 100;
        static void Main(string[] args)
        {
            int PlayerPosition = 0;
            int DieCount = 0;
            
            while (PlayerPosition < WINPOSITION)
            {
                
                Random Dice = new Random();
                int diceRoll = Dice.Next(1, 7);
                Console.WriteLine("Dice Roll " + diceRoll);
                int option = Dice.Next(0, 3);
                
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Snake No Ladder");
                        Console.WriteLine("Your Position is : " + PlayerPosition);
                        break;
                    case 1:
                        PlayerPosition += diceRoll;
                        
                        if (PlayerPosition > WINPOSITION)
                        {
                            PlayerPosition -= diceRoll;
                            Console.WriteLine("Stay in some previous position " + PlayerPosition);
                        }
                        Console.WriteLine("You Got Ladder");
                        Console.WriteLine("Your Position After Ladder is : " + PlayerPosition);
                        break;
                    case 2:
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        else
                        {
                            PlayerPosition -= diceRoll;
                        }
                        Console.WriteLine("You Got Snake");
                        Console.WriteLine("Your Position After Snake is : " + PlayerPosition);
                        break;
                        DieCount++;
                }
                
                DieCount++;
            }
            
            Console.WriteLine("The Number of times Dice Rolled is " + DieCount);
            Console.ReadLine();
        }
        
                

            
        
    }
}