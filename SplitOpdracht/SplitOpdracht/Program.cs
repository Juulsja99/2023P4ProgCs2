namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string content = File.ReadAllText("C:\\Users\\Juuls\\Documents\\2023P4ProgCs2\\SplitOpdracht\\SplitOpdracht\\stringsplit.txt");
            string[] value = content.Split(':');
            string keyvalue = value[i];
            Console.WriteLine(keyvalue);
            

        }
    }
}