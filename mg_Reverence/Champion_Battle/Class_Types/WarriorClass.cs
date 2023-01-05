using mg_Reverence.Champion_Battle.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Champion_Battle.Class_Types
{
    internal class WarriorClass : ClassType
    {
        ChampionStats stats;
        public WarriorClass()
        {
            this.id = 0;


            stats.experience = 0;
            stats.level = 0;
           
            stats.health = 100;
            stats.morale = 100;

            stats.strength = 5;
            stats.faith = 0;
            stats.blessing = 0;
            stats.charisma = 3;
            stats.speed = 1;




            stats.attack = 0;
            stats.defence = 0;
            stats.turn = 0;




            stats.regeneration = 0;
            stats.vampirism = 0;

            stats.block_chance = 0;
            stats.accuracy = 0;
            stats.dodge_chance = 0;

            stats.counter_chance = 0;
            stats.counter_damage = 0;
            stats.critical_chance = 0;
            stats.critical_damage = 0;
        }
        
    }
}
