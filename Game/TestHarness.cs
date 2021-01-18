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
            

            Weapon weapon1 = new Weapon("Iron Sword", "A basic sword forged from the common metal", 5);
            
            MagicItem magicItem1 = new MagicItem("Shiny ring", "Who knows what secrets it holds", 6, 4, 20);
            //Console.WriteLine(armor1);
            //Console.WriteLine(weapon1);
            //Console.WriteLine(magicItem1);

            Random rand = new Random();
            int random = rand.Next(10, 21);
            Player player1 = new Player("Clangster", 100, 100, 12, 10, 10, Race.Human, Class.Wizard, armor1, weapon1, magicItem1, 0, 1, 5, 0, 100, 1);
            
            //Console.WriteLine(player1);
            Enemey enemey1 = new Enemey("Goblin",EnemyLV.Easy);
            
            Enemey enemey2 = new Enemey("Orc", EnemyLV.Medium);
            Enemey enemey3 = new Enemey("Troll", EnemyLV.Hard);

            if (player1.HPPots >0)
            {

            }
            
        }//end main()
        

    }//end class
}//end namespace
