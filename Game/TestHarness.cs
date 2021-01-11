using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;

namespace Game
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Armor armor1 = new Armor("Leather Armor", "It's Better than Nothing", 5);
            Console.WriteLine(armor1);

            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);
            Console.WriteLine(weapon1);
            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 6, 4, 20);
            Console.WriteLine(magicItem1);

            
        }//end main()
    }//end class
}//end namespace
