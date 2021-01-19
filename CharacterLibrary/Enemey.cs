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

        

        public Enemey(string name, int health, int maxHealth, int limit,int attack, int defense,EnemyLV level, int lootDropRate, int armorWeaponDropRate, int magicItemDropRate, int hPPotDropRate, int goldDroped, int expDroped) : base(name, health, maxHealth, limit, attack, defense)
        {
            Level = level;
            LootDropRate = lootDropRate;
            ArmorWeaponDropRate = armorWeaponDropRate;
            MagicItemDropRate = magicItemDropRate;
            HPPotDropRate = hPPotDropRate;
            GoldDroped = goldDroped;
            ExpDroped = expDroped;
            
            
       
        }//end FQCTOR

        public Enemey(string name,  EnemyLV level ) : base(name)
        {
            Level = level;
            Count = 0;
           
            
            switch (Level)
            {
                case EnemyLV.Easy:
                    GoldDroped = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    ExpDroped = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    Limit = new Random().Next(6,9);
                    System.Threading.Thread.Sleep(50);
                    Attack = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    Defense = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    LootDropRate = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    ArmorWeaponDropRate = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    MagicItemDropRate = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    HPPotDropRate = new Random().Next(10, 21);
                    System.Threading.Thread.Sleep(50);
                    MaxHealth = new Random().Next(30, 51);
                    Health = MaxHealth;

                    break;
                case EnemyLV.Medium:
                    ExpDroped = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    GoldDroped = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    Limit = new Random().Next(8, 11);
                    System.Threading.Thread.Sleep(50);
                    Attack = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    Defense = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    LootDropRate = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    ArmorWeaponDropRate = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    MagicItemDropRate = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    HPPotDropRate = new Random().Next(20, 31);
                    System.Threading.Thread.Sleep(50);
                    MaxHealth = new Random().Next(50, 71);
                    Health = MaxHealth;
                    break;
                case EnemyLV.Hard:
                    GoldDroped = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    ExpDroped = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    Limit = new Random().Next(10,13);
                    System.Threading.Thread.Sleep(50);
                    Attack = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    Defense = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    LootDropRate = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    ArmorWeaponDropRate = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    MagicItemDropRate = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    HPPotDropRate = new Random().Next(30, 41);
                    System.Threading.Thread.Sleep(50);
                    MaxHealth = new Random().Next(70, 101);
                    Health = MaxHealth;
                    break;
                
            }//end switch

        }//end random value ctor
        public override string ToString()
        {
            return string.Format($"{base.ToString()}\n Difficulty: {Level}\nAttack: {Attack}\nDef: {Defense}\n Limit: {Limit}\nLootDrop: {LootDropRate}\nArmorweaponDrop: {ArmorWeaponDropRate}\nMagic Drop: {MagicItemDropRate}\nhpdrop: {HPPotDropRate}\nGold Droped: {GoldDroped}\n expdroped: {ExpDroped}");
        }

        // public override string ToString()
        // {
        //     return string.Format($"{base.ToString()}\nDifficulty: {Level}");
        // }


    }//end class
}//end namespace
