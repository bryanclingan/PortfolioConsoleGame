using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrrary;
using CharacterLibrary;

namespace Methods
{
    public class HpPotion
    {
        public static void useHPPotion(Player player)
        {
            if (player.HPPots>0)
            {
                player.HPPots -= 1;
                player.Health = player.Health +  Decimal.ToInt32(player.MaxHealth * .15m);
                
            }
            else
            {
                Console.WriteLine("You dont have any HP Potions!");
            }
        }
    }//end class
}//end namespace
