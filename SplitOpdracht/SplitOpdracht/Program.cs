namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string content = File.ReadAllText("C:\\Users\\Juuls\\Documents\\2023P4ProgCs2\\SplitOpdracht\\SplitOpdracht\\stringsplit.txt");
            string[] value = content.Split(':');
            string keyvalue = value[0];
            string[] cijferspervak = value[1].Split(",");
            string cijfer1 = cijferspervak[0];
            string cijfer2 = cijferspervak[1];
            Console.WriteLine(keyvalue);
            Console.WriteLine(cijfer1);
            Console.WriteLine(cijfer2);


        }
    }
}