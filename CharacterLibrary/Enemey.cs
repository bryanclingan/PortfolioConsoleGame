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
        public Random GoldDroped { get; set; }
        public Random ExpDroped { get; set; }

        

        public Enemey(string name, int health, int maxHealth, int limit, int attack, int defense,EnemyLV level, int lootDropRate, int armorWeaponDropRate, int magicItemDropRate, int hPPotDropRate, Random goldDroped, Random expDroped) : base(name, health, maxHealth, limit, attack, defense)
        {
            Level = level;
            LootDropRate = lootDropRate;
            ArmorWeaponDropRate = armorWeaponDropRate;
            MagicItemDropRate = magicItemDropRate;
            HPPotDropRate = hPPotDropRate;
            GoldDroped = goldDroped;
            ExpDroped = expDroped;

        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nDifficulty: {Level}");
        }
    }//end class
}//end namespace
