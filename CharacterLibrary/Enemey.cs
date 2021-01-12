using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public class Enemey:Character
    {
       

        public EnemyLV Level { get; set; }
        public int LootDropRate { get; set; }
        public int ArmorWeaponDropRate { get; set; }
        public int MagicItemDropRate { get; set; }
        public int HPPotDropRate { get; set; }
        public int GoldDroped { get; set; }
        public int ExpDroped { get; set; }

        

        public Enemey(string name, int health, int maxHealth, int limit, int attack, int defense,EnemyLV level, int lootDropRate, int armorWeaponDropRate, int magicItemDropRate, int hPPotDropRate, int goldDroped, int expDroped) : base(name, health, maxHealth, limit, attack, defense)
        {
            Level = level;
            LootDropRate = lootDropRate;
            ArmorWeaponDropRate = armorWeaponDropRate;
            MagicItemDropRate = magicItemDropRate;
            HPPotDropRate = hPPotDropRate;
            GoldDroped = goldDroped;
            ExpDroped = expDroped;
            switch (Level)
            {
                case EnemyLV.Easy:
                    GoldDroped = new Random().Next(10,21);
                    break;
                case EnemyLV.Medium:
                    GoldDroped = new Random().Next(20, 31);
                    break;
                case EnemyLV.Hard:
                    GoldDroped = new Random().Next(30, 41);
                    break;
                default:
                    break;
            }

        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nDifficulty: {Level}");
        }
    }//end class
}//end namespace
