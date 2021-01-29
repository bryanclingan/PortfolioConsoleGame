using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;
using CharacterLibrary;
using Methods;

namespace Game
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Armor armor1 = new Armor("Leather Armor", "It's Better than Nothing", 5);
            Armor armor2 = new Armor("Iron Armor", "sturdy", 10);

            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);
            Weapon weapon2 = new Weapon("Gold Sword", "ooooh shiny", 10);
            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 5, 5, 10);
            MagicItem magicItem2 = new MagicItem("Dull Ring", "Looks can be deceiving", 10, 10, 15);
            

            Player player1 = new Player("Clangster", 100, 100, 12, 10, 10, Race.Elf, Class.Ranger, armor1, weapon1, magicItem1, 0, 1, 5, 0, 100, 1);
            
            Console.WriteLine(player1);

            //player1.equipArmor(player1,player1.Armor, armor2);
            //Console.WriteLine(player1);
            //player1.equipWeapon(player1, player1.Weapon, weapon2);
            //Console.WriteLine(player1);
            //player1.equipMagicItem(player1, player1.MagicItem, magicItem2);
            //Console.WriteLine(player1);
            Enemy enemy = new Enemy("Orc", EnemyLV.Hard);
            Console.WriteLine(enemy);
            Combat.DoCombat(player1, enemy);
            

            

            
            

        }//end main()      

    }//end class
}//end namespace
