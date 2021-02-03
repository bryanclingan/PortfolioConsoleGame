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
            string[] easyMonsterNames = { "Slime", "Goblin", "Kobold", "Harpy", "Imp" };
            string[] mediumMonsterNames = { "Troll", "Werewolf", "Ghoul", "Leshin", "Siren" };
            string[] hardMonsterNames = { "Orc", "Giant", "Griffen", "Dijn", "Golem" };
            Random rand = new Random();
            int randNbr;
            randNbr = rand.Next(easyMonsterNames.Length);
            Enemy easyMonster = new Enemy(easyMonsterNames[randNbr], EnemyLV.Easy);

            randNbr = rand.Next(mediumMonsterNames.Length);
            Enemy mediumMonster = new Enemy(mediumMonsterNames[randNbr], EnemyLV.Medium);

            randNbr = rand.Next(hardMonsterNames.Length);
            Enemy hardMonster = new Enemy(hardMonsterNames[randNbr], EnemyLV.Hard);
            Enemy monster = new Enemy("oops game broke", EnemyLV.Boss);
            if (level == EnemyLV.Easy)
            {
                //randNbr = rand.Next(easyMonsterNames.Length);
                //Enemy monster = new Enemy(easyMonsterNames[randNbr], EnemyLV.Easy);
                //return new Enemy(easyMonsterNames[randNbr], EnemyLV.Easy);
                return easyMonster;
            }
            if (level == EnemyLV.Medium)
            {
                //randNbr = rand.Next(mediumMonsterNames.Length);
                //Enemy monster = new Enemy(mediumMonsterNames[randNbr], EnemyLV.Medium);
                //return new Enemy(mediumMonsterNames[randNbr], EnemyLV.Medium);
                return mediumMonster;
            }
            if (level == EnemyLV.Hard)
            {
                //randNbr = rand.Next(hardMonsterNames.Length);
                //Enemy monster = new Enemy(hardMonsterNames[randNbr], EnemyLV.Hard);
                //return new Enemy(hardMonsterNames[randNbr], EnemyLV.Hard);
                return hardMonster;
            }
            else
            {
              
                return monster;
            }


        }
    }
}
