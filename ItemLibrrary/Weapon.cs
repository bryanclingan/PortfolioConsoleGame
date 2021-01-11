using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrrary
{
    public class Weapon:Item
    {


        private int _atkBoost;

        public int AtkBoost
        {
            get { return _atkBoost; }
            set { _atkBoost = value > 0 ? value : 1; }
        }//end DefBoost
        public Weapon(string name, string desc, int atkBoost) : base(name, desc)
        {
            AtkBoost = atkBoost;
        }//end FQCTOR



        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nAttack Boost: {AtkBoost}");
        }//end ToString()
    }//end class
}//end namespace
