using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
        internal Element element;


        internal void UseOn(ConsoleMon targetMon, ConsoleMon casterMon)
        {
            casterMon.DepleteEnergy(energyCost);
            targetMon.TakeDamage(damage);
            if(targetMon.weakness == element)
            {
                targetMon.TakeDamage(damage/2);
            }
        }
    }

   
    

}
