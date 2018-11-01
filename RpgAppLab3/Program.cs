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
<<<<<<< HEAD
                var allNames = new[] { "Briana", "Ben", "David", "Dana", "Felicia", "Felix", "Legolas" };
=======
                var allNames = new[] { "Briana", "Ben", "David", "Dana", "Felicia", "Felix", "legolas", "Elrond"};
>>>>>>> elven-names
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
