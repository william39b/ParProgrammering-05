using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_05
{
    internal class Wizard
    {
        public Wizard(string name, string house)
        {
            Name = name;
            House = house;
            Inventory = new string[2];
        }

        public string Name { get; set; }
        public string House { get; set; }
        public string[] Inventory { get; set; }

        private string[] _houses = { "Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin" };


        public void CreateWizard(Wizard person)
        {
            Console.WriteLine("What is the name of your new Wizard?");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            person.Name = name;
            person.House = RandomHouse();
            Console.WriteLine($"\nWellcome to Hogwarts {person.Name}");
            Console.WriteLine("Your new house is...");
            Thread.Sleep(2000);
            Console.WriteLine($"{person.House}!");
            Console.ReadKey();
        }

        public string RandomHouse()
        {
            Random random = new Random();
            return _houses[random.Next(4)];
        }

        public void WizardInfo()
        {
            Console.WriteLine(
                $"Name:  {Name}\n" +
                $"House: {House}\n" +
                $"Wand:  {Inventory[0]}\n" +
                $"Pet:   {Inventory[1]}\n");
            Console.Write("Press ENTER to continue: ");
            Console.ReadKey();
        }
        
    }
}
