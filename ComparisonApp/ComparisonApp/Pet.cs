﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonApp
{
    class Pet : Animal //Derived class 1
    {
        public string name;
        string owner;

        public Pet(int numLegs, string animalColor, int animalAge, string petName, string petOwner) : base(numLegs, animalColor, animalAge)
        {
            name = petName;
            owner = petOwner;
        }

        public void printInfo()
            {
                Console.WriteLine(name + " is owned by " + owner);
            }

        public void changeOwner(string newOwner)
        {
            owner = newOwner;

            Console.WriteLine("The new owner of " + name + " is " + owner );
        }
    }
}
