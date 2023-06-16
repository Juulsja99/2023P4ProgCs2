namespace ListOpdracht
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> Birds = new List<string>() {"uil", "kraai", "hond", "papagaai"  };
            List<string> Birds2 = new List<string>() { "meeuw", "duif" };

            Birds.Remove("hond");
            Birds.AddRange(Birds2);

            foreach (string bird in Birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}