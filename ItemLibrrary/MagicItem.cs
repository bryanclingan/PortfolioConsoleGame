using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrrary
{
    public class MagicItem:Item
    {
        

        public int AtkBoost { get; set; }
        public int DefBoost { get; set; }
        public int HealthBoost { get; set; }

        public MagicItem(string name, string desc,int atkBoost, int defBoost, int healthBoost) : base(name, desc)
        {
            AtkBoost = atkBoost;
            DefBoost = defBoost;
            HealthBoost = healthBoost;

        }//end FQCTOR
        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nAttack Boost: {AtkBoost}\nDefense Boost: {DefBoost}\nHealth Boost: {HealthBoost}");
        }//end ToString()


    }//end class
}//end namespace
