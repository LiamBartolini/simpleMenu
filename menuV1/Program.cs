using System;
using menuV1.Models;

namespace menuV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Benvenuto!!";
            string[] options = { "Primo", "Secondo", "Terzo" };
            Menu.Initialize(prompt, options);
            int selectedIndex = Menu.Run();

            Console.ForegroundColor = ConsoleColor.Red;
            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("PRIMO");
                    break;
                case 1:
                    Console.WriteLine("SECONDO");
                    break;
                case 2:
                    Console.WriteLine("TERZO");
                    break;
            }

            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}