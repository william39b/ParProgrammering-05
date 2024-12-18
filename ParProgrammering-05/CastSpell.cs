using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_05
{
    internal class CastSpell
    {
        public static void Spell()
        {
            Console.Clear();
            Console.WriteLine("Cast a spell");
            Console.Write("Spell: ");
            string spell = Console.ReadLine().ToLower();
            Console.WriteLine(Spells(spell));
            Console.WriteLine("Try another spell?");
            Console.Write("(y/n) ");
            var input = Console.ReadLine();
            if (input == "y") Spell();
        }

        static string Spells(string spell)
        {
            if (spell == "vingardium leviosa") return "You made a feather fly!";
            else if (spell == "hokus pokus") return "You lit some fireworks!";
            else return "Nothing happened.";
        }
    }
}
