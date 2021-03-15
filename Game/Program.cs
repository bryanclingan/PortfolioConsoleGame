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

            Console.Title = "Game";

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
                    playerClass = Class.Wizard;
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
            Console.WriteLine("Lets start an adventure!!");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            bool understand = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Let me explain how this works.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("You will be setting off to try and clear the local dungeon.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Many have tried and many have failed... perhaps you will be the first to suceed");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("In the dungeon fighting does not work the same way it does out here. These monsters prefer to play cards to decide who gets to attack. They are very honorable they will not try any tricks if they lose.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The object of the card game these monsters like is a simple version of blackjack. However these guys don't handle large numbers well so these decks only have 24 cards numbered 1-6.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The goal (much like blackjack) is to get a higher card count than your opponent without going over your limit. I can tell you that your limit is 12, as for the monsters, their limits are different depending on their strength");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("I think that's about it. Do you Understand? Y/N");
                ConsoleKey understood = Console.ReadKey().Key;
                Console.Clear();
                switch (understood)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("Great!! Good Luck!!");
                        understand = true;
                        Console.Clear();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Thats okay I will explain it again from the top.");
                        System.Threading.Thread.Sleep(2000);
                        understand = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Looks like you did not understand...lets go over it again.");
                        System.Threading.Thread.Sleep(2000);
                        understand = false;
                        Console.Clear();
                        break;
                }
            } while (!understand);

            Random random = new Random();
            Console.WriteLine("You have entered the dungeon!");

            System.Threading.Thread.Sleep(2000);

            bool playerAlive = CombatBreak.Break(player);
            //1
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
            }
            playerAlive = CombatBreak.Break(player);
            //2
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
            }

            playerAlive = CombatBreak.Break(player);
            //3
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
            }

            playerAlive = CombatBreak.Break(player);
            //4
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
            }

            playerAlive = CombatBreak.Break(player);
            //5
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
            }
            playerAlive = CombatBreak.Break(player);
            //6
            if (playerAlive)
            {
                int randnum = random.Next(12);
                if (randnum >= 6)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Medium));
                }
                else if (randnum <= 5)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
                }
                
            }
            playerAlive = CombatBreak.Break(player);
            //7
            if (playerAlive)
            {
                Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Medium));
            }

            playerAlive = CombatBreak.Break(player);
            //8
            if (playerAlive)
            {
                int randnum = random.Next(12);
                if (randnum >= 6)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Medium));
                }
                else if (randnum <= 5)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Easy));
                }

            }
            playerAlive = CombatBreak.Break(player);
            //9
            if (playerAlive)
            {
                int randnum = random.Next(12);
                if (randnum >= 6)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Medium));
                }
                else if (randnum <= 5)
                {
                    Combat.DoCombat(player, GetMonster.GetEnemy(EnemyLV.Hard));
                }

            }
            playerAlive = CombatBreak.Break(player);
            //boss
            if (playerAlive)
            {


                Enemy boss1 = new Enemy("Marble Golem", 125, 125, 12, 40, 40, EnemyLV.Boss, 50, 50, 50, 50, 50, 100);
                Combat.DoCombat(player, boss1);
                playerAlive = CombatBreak.Break(player);
            }
        }//end main()
    }//end class
}//end namespace
