using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Champion_Battle.Stats
{
    internal class ChampionStats
    {
        // leveling
        internal double experience;
        internal double level;

        //meters
        internal double health;
        internal double morale;

        //core
        internal double strength; // physical
        internal double faith; // offence magic
        internal double blessing; // healing/defence
        internal double charisma; //buffs
        internal double speed; // turn

        //active outputs
        internal double attack;
        internal double defence;
        internal double turn;


        //passive outputs
        internal double regeneration;
        internal double vampirism;

        internal double block_chance;
        internal double accuracy;
        internal double dodge_chance;

        internal double counter_chance;
        internal double counter_damage;
        internal double critical_chance;
        internal double critical_damage;




    }
}
