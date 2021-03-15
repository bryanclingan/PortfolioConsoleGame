using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;
using ItemLibrrary;

namespace Methods
{
   public class GetItem
    {
        public static Armor GetArmor(Player player)
        {
            string[] armorName = { "Leather Armor", "Iron Armor", "Plate Armor" };
            string[] armorDesc = { "Made from the hide of an animal", "Forged by human craftsmen in the city", "Heavy armor made by the dwarves"};
            Random rand = new Random();
            int randNBR = rand.Next(armorName.Length);

            int defBoost = rand.Next(10,(player.Level*10+1));
            return new Armor(armorName[randNBR], armorDesc[randNBR], defBoost);
            
        }
        public static Weapon GetWeapon(Player player)
        {
            string[] weaponName = { "Iron Sword", "Battle-Axe", "Dagger" };
            string[] weaponDesc = { "A trusty Iron Sword","Perfect for swinging", "Great for being sneaky" };
            Random rand = new Random();
            int randNBR = rand.Next(weaponName.Length);
            int atkBoost = rand.Next(10, (player.Level * 10 + 1));
            return new Weapon(weaponName[randNBR], weaponDesc[randNBR], atkBoost);

        }
        public static MagicItem GetMagicItem(Player player)
        {
            Random rand = new Random();
            int randomStats = rand.Next(1, 2);
            string[] magicName = { "Dull Ring", "Gold Ring", "Gemstone Ring" };
            string[] magicDesc = { "This ring has lost its shine", "Probally worth some money at market", "A ring with a valueable stone set in it" };
            int randName = rand.Next(magicName.Length);
            
            switch (randomStats)
            {
                case 1:
                    int statToBoost = rand.Next(1, 4);
                    switch (statToBoost)
                    {
                        case 1:
                            int atkBoost = rand.Next(10, (player.Level * 10 + 1));
                            return new MagicItem(magicName[randName], magicDesc[randName], atkBoost, 0, 0);
                            break;
                        case 2:
                            int defBoost = rand.Next(10, (player.Level * 10 + 1));
                            return new MagicItem(magicName[randName], magicDesc[randName], 0,defBoost, 0);
                            break;
                        case 3:
                            int healthBoost = rand.Next(10, (player.Level * 10 + 1))*2;
                            return new MagicItem(magicName[randName], magicDesc[randName], 0, 0, healthBoost);
                            break;
                    }
                    break;

                case 2:
                    int statsToBoost = rand.Next(1, 4);
                    switch (statsToBoost)
                    {
                        case 1:
                            int atkBoost = rand.Next(10, (player.Level * 5 + 6));
                            int defBoost = rand.Next(10, (player.Level * 5 + 6));
                            return new MagicItem(magicName[randName], magicDesc[randName], atkBoost, defBoost, 0);
                            break;
                        case 2:
                            int defBoost2 = rand.Next(10, (player.Level * 5 + 6));
                            int healthBoost = rand.Next(10, (player.Level * 5 + 6)) * 2;
                            return new MagicItem(magicName[randName], magicDesc[randName], 0, defBoost2, healthBoost);
                            break;
                        case 3:
                            int healthBoost2 = rand.Next(10, (player.Level * 5 + 6)) * 2;
                            int atkBoost2 = rand.Next(10, (player.Level * 5 + 6));
                            return new MagicItem(magicName[randName], magicDesc[randName], atkBoost2, 0, healthBoost2);
                            break;
                    }
                    break;
                
            }
            return new MagicItem("oops something broke", "oops something broke", 0, 0, 0);
        }

    }
}
