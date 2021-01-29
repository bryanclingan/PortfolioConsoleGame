using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterLibrary;
using ItemLibrrary;

namespace Methods
{
    public class GetMonster
    {
        public static Enemy GetEnemy(EnemyLV level)
        {
            string[] easyMonsterNames = { "Slime", "Goblin", "Kobold", "Harpy","Imp" };
            string[] mediumMonsterNames = { "Troll", "Werewolf", "Ghoul","Leshin","Siren" };
            string[] hardMonsterNames = { "Orc", "Giant", "Griffen","Dijn","Golem" };
            Random rand = new Random();
            int randNbr;

            switch (level)
            {
                case EnemyLV.Easy:
                    randNbr = rand.Next(easyMonsterNames.Length);
                    return new Enemy(easyMonsterNames[randNbr], EnemyLV.Easy);
                    break;
                case EnemyLV.Medium:
                    randNbr = rand.Next(mediumMonsterNames.Length);
                    return new Enemy(mediumMonsterNames[randNbr], EnemyLV.Medium);
                    break;
                case EnemyLV.Hard:
                    randNbr = rand.Next(hardMonsterNames.Length);
                    return new Enemy(hardMonsterNames[randNbr], EnemyLV.Easy);
                    break;
               
            }
            //if (level == "Easy")
            //{
            //    randNbr = rand.Next(easyMonsterNames.Length);
            //    return new Enemy(easyMonsterNames[randNbr], EnemyLV.Easy);
            //}
            //if (level == "Medium")
            //{
            //    randNbr = rand.Next(mediumMonsterNames.Length);
            //    return new Enemy(mediumMonsterNames[randNbr], EnemyLV.Medium);
            //}
            //if (level == "Hard")
            //{
            //    randNbr = rand.Next(hardMonsterNames.Length);
            //    return new Enemy(hardMonsterNames[randNbr], EnemyLV.Easy);
            //}
        }
    }
}
