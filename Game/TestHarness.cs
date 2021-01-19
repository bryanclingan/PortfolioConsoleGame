using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;
using CharacterLibrary;
using Methods;

namespace Game
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Armor armor1 = new Armor("Leather Armor", "It's Better than Nothing", 5);


            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);

            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 5, 5, 10);


            
            Player player1 = new Player("Clangster", 100, 100, 12, 10, 10, Race.Elf, Class.Ranger, armor1, weapon1, magicItem1, 0, 1, 5, 0, 100, 1);

            Console.WriteLine(player1);
            bool test = true;
            do
            {


                Console.WriteLine("L for Level up X for 50XP");

                ConsoleKey choice = Console.ReadKey().Key;

                switch (choice)
                {
                    case ConsoleKey.X:
                        player1.ExpEarned += 100;
                        Console.WriteLine($"{player1.ExpEarned}/{player1.ExpNeededLvUp}");
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        LevelUp.levelUP(player1);
                        Console.WriteLine(player1);
                        break;

                    default:
                        test = false;
                        break;
                }


            } while (test);

        }//end main()      

    }//end class
}//end namespace
