using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type command");
                string command = Console.ReadLine();
                Console.WriteLine("Type path");
                string path = Console.ReadLine();
                try
                {
                    if (command.Equals("dir")) Dir(path);
                    if (command == "mkdir") Mkdir(path);
                    if (command == "cd") cd(path);
                    if (command == "rmdir") Rmdir(path);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
                
                
            }
        }
        static void Dir(string path)
        {
            string[] filePaths = Directory.GetFiles(path);
            foreach (var i in filePaths)
            {
                Console.WriteLine(i);
            }
        }
        static void Mkdir (string path)
        {
            string addPath = Console.ReadLine();
            Directory.CreateDirectory(path + addPath);
        }
        static void Rmdir(string path)
        {
            Rmdir(path);
        }
        static void cd(string path)
        {
            Directory.SetCurrentDirectory(path);
        }
    }
}
