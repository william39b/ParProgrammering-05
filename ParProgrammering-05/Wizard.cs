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


        public void WizardInfo()
        {
            Console.WriteLine(
                $"Name:  {Name}\n" +
                $"House: {House}\n" +
                $"Wand:  {Inventory[0]}\n" +
                $"Pet:   {Inventory[1]}\n");
        }
    }
}
