using System;
using System.ComponentModel;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\\Users\\Juuls\\Documents\\2023P4ProgCs2\");
            //FileInfo file = new FileInfo(@"C:\\Users\\Juuls\\Documents\\2023P4ProgCs2\\FileDirOpdracht\\FileDirOpdracht\\Program.cs");

            foreach (var di in dir.GetDirectories()) 
            {
                Console.WriteLine(di.FullName);
            }

            foreach (var fi in dir.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }

            


        }
    }
}