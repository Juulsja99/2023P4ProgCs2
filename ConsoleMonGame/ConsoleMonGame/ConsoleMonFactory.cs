using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {

        internal void Load (string datafile)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Juuls\Documents\2023P4ProgCs2\ConsoleMonGame\ConsoleMonGame\monsterdata.txt");
            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
            
        }

    }
}
