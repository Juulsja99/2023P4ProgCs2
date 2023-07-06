using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        public int damage { get; set; }
        public int energyCost { get; set; }
        public string name { get; set; }
        public Element element { get; set; }


        public Skill()
        {

        }

        internal Skill(int damage, int energeyCost, string name, Element element)
        {
            this.damage = damage;
            this.energyCost = energeyCost;
            this.name = name;
            this.element = element;

            
        }


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
