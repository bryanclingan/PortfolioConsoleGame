using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;
using ItemLibrrary;

namespace Methods
{
    public class Combat
    {

        public static void DoCombat(Player player, Enemy enemy)
        {
            bool playerStand = false;
            bool enemeyStand = false;
            bool pMenu = false;
            List<int> pCards = new List<int> { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            List<int> eCards = new List<int> { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            Random randcard = new Random();
            int eLastCard = 0;
            int plastCard = 0;
            do
            {
                
                player.Count = 0;
                enemy.Count = 0;
                playerStand = false;
                enemeyStand = false;
                
                do
                {
                    if (pCards.Count == 0)
                    {
                        pCards = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
                    }
                    if (eCards.Count == 0)
                    {
                        eCards = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
                    }

                    if (!playerStand)
                    {

                        Console.WriteLine($"{enemy.Name}\n{enemy.Count}/{enemy.Limit}\n{enemy.Health}/{enemy.MaxHealth}\nLast Card Drawn: {eLastCard}\n");

                        Console.WriteLine($"{player.Name}\n{player.Count}/{player.Limit}\n{player.Health}/{player.MaxHealth}\nLast Card Drawn: {plastCard}");
                        do
                        {

                            pMenu = false;
                            Console.WriteLine("D)Draw\nS)Stand\nH)Use HP Potion");
                            ConsoleKey choice = Console.ReadKey().Key;
                            switch (choice)
                            {
                                case ConsoleKey.D:
                                    int carddrawn = randcard.Next(pCards.Count);
                                    player.Count += pCards[carddrawn];
                                    plastCard = pCards[carddrawn];
                                    pCards.RemoveAt(carddrawn);                                    
                                    
                                    pMenu = true;
                                    if (player.Count == player.Limit)
                                    {
                                        playerStand = true;
                                    }
                                    if (player.Count>player.Limit)
                                    {
                                        if (player.Count - plastCard> enemy.Count|| player.Count - plastCard ==enemy.Count)
                                        {
                                            player.Count = enemy.Count - 1;
                                            playerStand = true;
                                        }
                                        if (player.Count - plastCard <enemy.Count)
                                        {
                                            player.Count -= plastCard;
                                            playerStand = true;
                                        }
                                    }
                                    break;
                                case ConsoleKey.S:
                                    playerStand = true;
                                    pMenu = true;
                                    break;
                                case ConsoleKey.H:
                                    HpPotion.useHPPotion(player);
                                    pMenu = true;
                                    break;
                                default:
                                    Console.WriteLine("Please make a valid Choice!!");
                                    pMenu = false;
                                    break;
                            }
                        } while (!pMenu);
                    }//end if

                    if (!enemeyStand)
                    {
                        if (enemy.Count < enemy.Limit - 2)
                        {
                            int carddrawn = randcard.Next(eCards.Count);
                            enemy.Count += eCards[carddrawn];
                            eLastCard = eCards[carddrawn];
                            eCards.RemoveAt(carddrawn);                        
                            
                            if (enemy.Count > enemy.Limit)
                            {
                                if (enemy.Count-eLastCard > player.Count|| enemy.Count - eLastCard == player.Count)
                                {
                                    enemy.Count = player.Count - 1;
                                    enemeyStand = true;
                                }//end if
                                if (enemy.Count-eLastCard < player.Count)
                                {
                                    enemy.Count -= eLastCard;
                                    enemeyStand = true;

                                }//end if
                            }//end if
                        }//end if


                        if (enemy.Count >= enemy.Limit - 2)
                        {
                            enemeyStand = true;
                        }//end if 

                    }//end if
                    Console.Clear();
                } while (!playerStand || !enemeyStand);

                if (player.Count > enemy.Count)
                {
                    int hits = player.Count - enemy.Count;
                    int hitdamage = player.Attack - enemy.Defense;
                    
                    if (hitdamage<=0)
                    {
                        hitdamage = 1;
                    }
                    
                    Console.WriteLine($"{player.Name} hit {enemy.Name} {hits} times for {hitdamage} per hit.\nTotal Damage: {hits*hitdamage}");
                    enemy.Health -= (hits * hitdamage);
                }
                if (player.Count < enemy.Count)
                {
                    int hits = enemy.Count - player.Count;
                    int hitdamage = enemy.Attack - player.Defense;
                    if (hitdamage <= 0)
                    {
                        hitdamage = 1;
                    }
                    Console.WriteLine($"{enemy.Name} hit {player.Name} {hits} times for {hitdamage} per hit.\nTotal Damage: {hitdamage * hits}");
                    player.Health -= (hits * hitdamage);

                }
                

            } while (player.Health > 0 && enemy.Health > 0);

            if (enemy.Health <= 0)
            {
                Console.WriteLine($"You have defeated {enemy.Name}\nYou have received {enemy.GoldDroped} Gold and {enemy.ExpDroped} XP");
                player.Gold += enemy.GoldDroped;
                player.ExpEarned += enemy.ExpDroped;
            }
        }//end method


    }//end class
}//end namespace
