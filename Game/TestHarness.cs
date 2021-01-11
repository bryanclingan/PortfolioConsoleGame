using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;
using CharacterLibrary;

namespace Game
{
    class TestHarness
    {
        static void Main(string[] args)
        {
            Armor armor1 = new Armor("Leather Armor", "It's Better than Nothing", 5);
            

            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);
            
            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 6, 4, 20);
            //Console.WriteLine(armor1);
            //Console.WriteLine(weapon1);
            //Console.WriteLine(magicItem1);

            
            Player player1 = new Player("Clangster", 100, 100, 12, 10, 10, Race.Human, Class.Wizard, armor1, weapon1, magicItem1, 0, 1, 5, 0, 100, 1);
            Console.WriteLine(player1);
           // Enemey enemey1 = new Enemey("Goblin", 50, 50, 6, 10, 10, EnemyLV.Easy, 25, 50, 50, 50,(new Random().Next(10, 21)),( new Random().Next(50,56)));
            
        }//end main()
    }//end class
}//end namespace
