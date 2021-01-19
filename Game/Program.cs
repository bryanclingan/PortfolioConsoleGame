using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;
using ItemLibrrary;
using Methods;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Game";
            
            Console.WriteLine("Welcome to the Game.\nWhat is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("What is your Race?\n1)Elf - Better Health Stat\n2)Dwarf - Better Defense Stat\n3)Human - Better Attack Stat");
            ConsoleKey race = Console.ReadKey().Key;
            Race playerRace;
            Console.Clear();

            switch (race)
            {
               
                
                case ConsoleKey.D1:
                    playerRace = Race.Elf;
                    Console.WriteLine("Elf- The long lived wood folk.");
                    break;
                case ConsoleKey.D2:
                    playerRace = Race.Dwarf;
                    Console.WriteLine("Dwarf - The short mountain folk");

                    break;
                case ConsoleKey.D3:
                    playerRace = Race.Human;
                    Console.WriteLine("Human- I think we all know what they are like");
                    break;
                
               
                default:
                    playerRace = Race.Human;
                    Console.WriteLine("That wasn't a choice, your clearly a Human");
                    break;
            }

            Console.WriteLine("What is your class?\n1)Knight - Best Defense Stat\n2)Wizard - Best Health Stat\n3)Ranger - Best Attack Stat");
            ConsoleKey classChoice = Console.ReadKey().Key;
            Class playerClass;
            Console.Clear();
            switch (classChoice)
            {
                case ConsoleKey.D1:
                    playerClass = Class.Knight;
                    Console.WriteLine("Knight- A noble calling.");
                    break;
                case ConsoleKey.D2:
                    playerClass =Class.Wizard ;
                    Console.WriteLine("Wizard - Much power hides in the secrets of magic.");

                    break;
                case ConsoleKey.D3:
                    playerClass = Class.Ranger;
                    Console.WriteLine("Ranger- The sharp shooting protectors.");
                    break;


                default:
                    playerClass = Class.Knight;
                    Console.WriteLine("That wasn't a choice, your now a Knight");
                    break;
                
            }
            Console.Clear();

            Armor armor1 = new Armor("Leather Armor", "It's Better than Nothing", 5);


            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);

            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 5, 5, 10);
            Player player = new Player(playerName, 100, 100, 12, 10, 10, playerRace, playerClass, armor1, weapon1, magicItem1, 50, 1, 5, 0, 100, 1);
            Console.WriteLine(player);

        }//end main()
    }//end class
}//end namespace
