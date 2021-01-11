using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Item(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n{Desc}");
        }//end ToString()


    }//end class
}//end namespace
