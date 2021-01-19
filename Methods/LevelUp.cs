using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;
using ItemLibrrary;

namespace Methods
{
    public class LevelUp
    {
        public static void levelUP(Player player)
        {
            if (player.ExpEarned>=player.ExpNeededLvUp)
            {
                player.ExpEarned -= player.ExpNeededLvUp;
                player.ExpNeededLvUp = player.ExpNeededLvUp + Decimal.ToInt32(player.ExpNeededLvUp * .25m);
                player.Level += 1;
                Random Rand = new Random();
                int healthboost = 0;
                if (player.PlayerRace == Race.Human)
                {
                    if (player.PlayerClass == Class.Knight)
                    {
                        player.Attack += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(5, 10);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Ranger)
                    {
                        player.Attack += Rand.Next(15,20);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(5, 10);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Wizard)
                    {
                        player.Attack += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(10, 15);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                }//end if
                if (player.PlayerRace == Race.Dwarf)
                {
                    if (player.PlayerClass == Class.Knight)
                    {
                        player.Attack += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(15,20);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(5, 10);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Ranger)
                    {
                        player.Attack += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(5, 10);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Wizard)
                    {
                        player.Attack += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(10, 15);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                }//end if
                if (player.PlayerRace == Race.Elf)
                {
                    if (player.PlayerClass == Class.Knight)
                    {
                        player.Attack += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(10, 15);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Ranger)
                    {
                        player.Attack += Rand.Next(10,15);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(10, 15);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                    if (player.PlayerClass == Class.Wizard)
                    {
                        player.Attack += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        player.Defense += Rand.Next(5,10);
                        System.Threading.Thread.Sleep(50);
                        healthboost = Rand.Next(15, 20);
                        player.MaxHealth += healthboost;
                        player.Health += healthboost;
                    }//end if
                }//if


            }//end if
            else
            {
                Console.WriteLine($"You need {player.ExpNeededLvUp - player.ExpEarned} xp to level up!");
            }//end else
        }//end levelUP method

    }
}
