using CharacterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CombatBreak
    {
        public static bool Break(Player player)
        {
            if (player.Health <= 0)
            {
                return false;
            }
            else
            {
                bool cont = false;
                do
                {
                    Console.WriteLine("Press S to see you stats\nPress C to continue the game");
                ConsoleKey choice = Console.ReadKey().Key;
                
                    switch (choice)
                    {
                        case ConsoleKey.S:
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.C:
                            Console.WriteLine("Lets Go!");
                            cont = true;
                            break;
                        default:
                            Console.WriteLine("Please make a choice");
                            break;
                    }
                } while (!cont);
                Console.Clear();
                return true;
            }
        }
    }
}
