using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;

namespace CharacterLibrary
{
    public class Player: Character
    {
        private int _hppots;

        public Race PlayerRace { get; set; }
        public Class PlayerClass { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public MagicItem MagicItem { get; set; }
        public int Gold { get; set; }
        public int MaxHPPots { get; set; }
        public int ExpEarned { get; set; }
        public int ExpNeededLvUp { get; set; }
        public int Level { get; set; }
        

        public int HPPots
        {
            get { return _hppots; }
            set { _hppots = value >= MaxHPPots ? MaxHPPots : value; }
        }//end HPPots
         
        public Player(string name, int health, int maxHealth, int limit, int attack, int defense,Race playerRace,Class playerClass,Armor armor,Weapon weapon, MagicItem magicItem,int gold, int hpPots, int maxHPPots,int expEarned, int expNeededLvUp,int level) : base(name, health, maxHealth, limit, attack, defense)
        {
            PlayerRace = playerRace;
            PlayerClass = playerClass;
            Armor = armor;
            Weapon = weapon;
            MagicItem = magicItem;
            Gold = gold;
            MaxHPPots = maxHPPots;
            HPPots = hpPots;
            ExpEarned = expEarned;
            ExpNeededLvUp = expNeededLvUp;
            Level = level;
            Attack = attack + Weapon.AtkBoost + MagicItem.AtkBoost;
            Defense = defense + Armor.DefBoost + MagicItem.DefBoost;
            MaxHealth = maxHealth + MagicItem.HealthBoost;
            Health = health + MagicItem.HealthBoost;
            Limit = limit;
            Count = 0;
            switch (PlayerRace)
            {
                case Race.Elf:
                    MaxHealth += 10;
                    Health += 10;
                    break;
                case Race.Dwarf:
                    Defense += 10;
                    break;
                case Race.Human:
                    Attack += 10;
                    break;
                
            }//end switch
            switch (PlayerClass)
            {
                case Class.Knight:
                    Defense += 10;
                    break;
                case Class.Wizard:
                    MaxHealth += 10;
                    Health += 10;
                    break;
                case Class.Ranger:
                    Attack += 10;
                    break;
                
            }//end switch
        }//end fqctor
        
       

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nRace: {PlayerRace}\nClass: {PlayerClass}\nLevel: {Level}\nExp: {ExpEarned}/{ExpNeededLvUp}\nStats:\nAttack: {Attack}\nDefense: {Defense}\nInventory:\nArmor: {Armor.Name} - {Armor.Desc}\nWeapon: {Weapon.Name} - {Weapon.Desc}\nMagic Item: {MagicItem.Name} - {MagicItem.Desc}\nHealth Potions: {HPPots}/{MaxHPPots}\n");
        }
    }//end class
}//emd namespace
