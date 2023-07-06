using System.IO;

namespace FileIOOopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] content = File.ReadAllLines(@"C:\Users\Juuls\Documents\2023P4ProgCs2\FileIOOopdracht\FileIOOopdracht\Leesdezefile.txt");

            DirectoryInfo output = new DirectoryInfo(@"C:\Users\Juuls\Documents\2023P4ProgCs2\FileIOOopdracht\FileIOOopdracht");
            {
                output.Create();
            }
            


            string[] text = new string[] { "nieuwe text" };



            File.WriteAllLines(@"C:\Users\Juuls\Documents\2023P4ProgCs2\FileIOOopdracht\FileIOOopdracht\mijnnieuwefile.txt", text);

           


            foreach (string line in content)
            {
                Console.WriteLine(line, text);
            }
        }
    }
}