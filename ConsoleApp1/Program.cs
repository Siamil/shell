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
            string command = "";
            string path = @"C:\Users\";
            while (true)
            {

                
                    Console.WriteLine("Type command");
                    string input = Console.ReadLine();
                    var splitted = input.Split(' ');
                if (splitted.Length == 1)
                {
                    command = splitted[0];
                }
                else if (splitted.Length == 2)
                {
                    command = splitted[0];
                    path = splitted[1];
                }
                else Console.WriteLine("Wrong command");
                    try { 
                    if (command == "dir") Dir(path); 
                    else if (command == "mkdir") Mkdir(path);
                    else if (command == "cd") cd(path);
                    else if (command == "rmdir") Rmdir(path);
                    else Console.WriteLine("Wrong command");
                }
                catch (Exception e)
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
