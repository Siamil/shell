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
                string command = "";
                string path = @"C:\Users\";
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

                if (command == "dir")
                    try
                    {
                        Dir(path);
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("path: " + path + " not found");
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine("You dont have the required permission. ");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("Invalid path: " + path);
                    }


                else if (command == "mkdir")
                    try
                    {
                        Mkdir(path);
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("path: " + path + " not found");
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine("You dont have the required permission. ");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("Invalid path: " + path);
                    }
            
                    
                else if (command == "cd")
                    try
                    {
                        cd(path);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("path: " + path + " is empty.");
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Invalid drive is specified, or drive is unavailable ");
                    }
                    catch(System.IO.DirectoryNotFoundException)
                    {
                        Console.WriteLine("Path:" +path+" not found ");
                    }
                else if (command == "rmdir")
                    try
                    {
                        Rmdir(path);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("path: " + path + " is empty.");
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Directory does not exist.");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Target directory contains files.");
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
