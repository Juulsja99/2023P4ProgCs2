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



        internal List<ConsoleMon> LoadJson(string datafile)
        {
            
            string json = File.ReadAllText(datafile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
           
            Console.WriteLine(templates[0].name);
            


            Console.WriteLine(json);

            return templates;
        }


        internal Skill CopySkill(Skill copyFrom)
        {
           Skill copyResult= new Skill(90, 80, "FireBlade", Element.Fire);
           
            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom) 
        {
            ConsoleMon copyResult= new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);
            copyResult.skills = new List<Skill>();
            foreach (Skill skills in copyFrom.skills)
            {
                CopySkill.Add(copyResult);

                
            }
            return copyResult;
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
