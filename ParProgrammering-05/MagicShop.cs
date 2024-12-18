﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_05
{
    internal class MagicShop
    {
        public MagicShop(Wizard wizard)
        {
            Wizard = wizard;
        }

        public Wizard Wizard { get; set; }

        private string[] _wands = { "føniksstav", "unikornstav", "trollstav" };
        private string[] _pets = { "Cat", "Owl", "Rat" };


        public void Shop()
        {
            Console.WriteLine("What do you want to buy?");
            Console.WriteLine("[1] Wand \n[2] Pet\n");
            var input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Wands();
                    break;
                case "2":
                    Pets();
                    break;
            }

        }

        public void Wands()
        {
            for (int i = 0; i < _wands.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {_wands[i]}");
            }
            var newWand = Convert.ToInt32(Console.ReadLine()) - 1;
            Wizard.Inventory[0] = _wands[newWand];
        }

        public void Pets()
        {
            for (int i = 0; i < _pets.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {_pets[i]}");
            }
            var newPet = Convert.ToInt32(Console.ReadLine()) - 1;
            Wizard.Inventory[1] = _pets[newPet];
        }


    }
}