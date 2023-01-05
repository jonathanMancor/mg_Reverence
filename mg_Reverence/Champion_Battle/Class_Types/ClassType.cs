using mg_Reverence.Champion_Battle.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mg_Reverence.Champion_Battle.Class_Types
{
    internal class ClassType
    {
        internal int id;
        internal string name;
        internal string description;
        internal int ;
        ChampionStats stats;


        internal void CalculateAttack()
        {
            stats.attack *= 1;
        }
        internal void CalculateDefence()
        {
            stats.defence *= 1;
        }
        internal void CalculateTurn()
        {

        }

        //Equipment equip;
        //ChampionActions actions;

    }
}
