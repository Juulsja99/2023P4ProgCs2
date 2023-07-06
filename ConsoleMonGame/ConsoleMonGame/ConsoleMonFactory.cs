using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        ConsoleMon dataMon = new ConsoleMon();



        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            return 
            Console.WriteLine(templates[0].name);
            


            Console.WriteLine(json);
        }

       
        



        internal void Load (string datafile)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Juuls\Documents\2023P4ProgCs2\ConsoleMonGame\ConsoleMonGame\monsterdata.txt");



            foreach (string line in lines) 
            {
                string[] typeSplit = line.Split('|');

                string[] consoleMonData = typeSplit[0].Split(",");

                int energy = int.Parse(consoleMonData[2]);

                int health = int.Parse(consoleMonData[4]);

                dataMon.name = consoleMonData[0];
                dataMon.health = health;
                dataMon.energy= energy;
               

               
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.health);
                Console.WriteLine(dataMon.energy);
            }
            
        }

       

    }
}
