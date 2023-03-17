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

        public Dog(int numLegs, string animalColor, int animalAge, string petName, string petOwner, string dogBreed) : base(numLegs, animalColor, animalAge, petName, petOwner)
        {
            breed = dogBreed;
        }

        public void bark()
        {
            Console.WriteLine("Woof woof!");
        }

        public override void run() //override
        {
            Console.WriteLine("This dog is running on " + numberOfLegs + " legs.");
        }
    }
}
