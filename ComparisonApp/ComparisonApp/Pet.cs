using System;
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

        public Pet(int numLegs, string animalColor, int animalAge, string petName, string petOwner)
        {
            numberOfLegs = numLegs;
            color = animalColor;
            age = animalAge;
            name = petName;
            owner = petOwner;
        }

        public void printInfo()
        {
            Console.WriteLine(name + " is owned by " + owner);
        }
    }
}
