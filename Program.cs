// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    
    public static void MenuOption(string option)
    {
        switch (option)
        {
            case "help":
                Console.WriteLine("Help.");
                break;
            case "add":
                Console.WriteLine("find");
                break;     
                   
                default:
                Console.WriteLine("help and find.");
                break;
        }
    }

    
    static void Main(string[] args)
    {
        Console.WriteLine("A menu with only help and find, Just like me!");
        string userOption = Console.ReadLine(); 
        MenuOption(userOption); 
    }
}
