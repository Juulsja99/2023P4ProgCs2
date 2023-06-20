using System.IO;

namespace FileIOOopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] content = File.ReadAllLines(@"C:\Users\Juuls\Documents\2023P4ProgCs2\FileIOOopdracht\FileIOOopdracht\Leesdezefile.txt");

            string[] text = new string[] { "nieuwe text" };
            string file = @"C:\Users\Juuls\Documents\2023P4ProgCs2\FileIOOopdracht\FileIOOopdracht\FileIOOopdracht.csproj/mijnniewefile.txt";

            File.WriteAllLines(file, text);



            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
        }
    }
}