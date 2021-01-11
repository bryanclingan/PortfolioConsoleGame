using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrrary
{
    public class Armor: Item
    {
        private int _defBoost;
        
        public int DefBoost
        {
            get { return _defBoost; }
            set { _defBoost=value > 0 ? value : 1; }
        }//end DefBoost
        public Armor(string name, string desc,int defBoost) : base(name, desc)
        {
            DefBoost = defBoost;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nDefense Boost: {DefBoost}");
        }//end ToString()

    }//end class
}//end namespace
