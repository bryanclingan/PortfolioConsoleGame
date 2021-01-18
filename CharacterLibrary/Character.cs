using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public class Character
    {
        private string _name;
        private int _health;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MaxHealth { get; set; }
        public int Limit { get; set; }

        public string Name
        {
            get { return  _name; }
            set { _name = value.Length > 1 ? value : "Unknown name"; }
        }//end Name
        public int Health
        {
            get { return _health; }
            set { _health = value <= MaxHealth ? value : MaxHealth; }
        }//end Health

        public Character(string name, int health, int maxHealth, int limit, int attack, int defense)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = health;            
            Limit = limit;
            Attack = attack;
            Defense = defense;
        }//end FQCTOR
        public Character(string name, int health, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = health;
        }
        public Character()
        {

        }//end paramterless ctor
        public Character(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return string.Format($"{Name}\nHP: {Health}/{MaxHealth}");
        }//end ToString()

    }//end class
}//end namespace
