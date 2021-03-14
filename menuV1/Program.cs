using System;
using menuV1.Models;
using static System.Console;

namespace menuV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Welcome!!";
            string[] options = { "Primo", "Secondo", "Terzo" };
            //Menu.Initialize("Welcome!!", new string[] { "Primo", "Secondo", "Terzo" });
            Menu.Initialize(prompt, options);
            int selectedIndex = Menu.Run();

            ForegroundColor = ConsoleColor.Red;
            switch (selectedIndex)
            {
                case 0:
                    WriteLine("Things about first choice");
                    break;
                case 1:
                    WriteLine("Things about second choice");
                    break;
                case 2:
                    WriteLine("Things about third choice");
                    break;
            }

            ResetColor();
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}