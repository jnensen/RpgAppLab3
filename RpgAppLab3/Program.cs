using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();
            if(command == "roll d20")
            {
                var diceRoll = rnd.Next(20) + 1;
                Console.WriteLine($"your dice roll was: {diceRoll}");
            }
            if (command == "names")
            {

                var allNames = new[] { "Briana", "Ben", "David", "Dana", "Felicia", "Felix", "legolas", "Elrond"};

                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            if (command == "Tolkien names")
            {
                var tolkienNames = new[] { "legolas", "Elrond", "Frodo", "Aragaron", "Gandalf" };
                var randomIndex = rnd.Next(tolkienNames.Length);
                Console.WriteLine(tolkienNames[randomIndex]);
            }
            if (command == "80s action")
            {
                var actionNames = new[] { "Terminator", "Alien", "Leathal weapon" };
                var randomIndex = rnd.Next(actionNames.Length);
                Console.WriteLine(actionNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
