using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonApp
{
    class Dog : Pet //derived class 2
    {
        public string breed;

        public Dog(int numLegs, string animalColor, int animalAge, string petName, string petOwner, string dogBreed)
        {
            numberOfLegs = numLegs;
            color = animalColor;
            age = animalAge;
            name = petName;
            owner = petOwner;
            breed = dogBreed;
        }

        public void bark()
        {
            Console.WriteLine("Woof woof!");
        }

        public void run()
        {
            Console.WriteLine("This dog is running on " + numberOfLegs + " legs.");
        }
    }
}
