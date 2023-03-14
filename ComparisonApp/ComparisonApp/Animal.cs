using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonApp
{
    class Animal //Base class
    {
        public int numberOfLegs;
        public string color;
        public int age;

        public Animal(int numLegs, string animalColor, int animalAge)
        {
            numberOfLegs = numLegs;
            color = animalColor;
            age = animalAge;
        }

        public virtual void run()
        {
            Console.WriteLine("This animal is running on " + numberOfLegs + " legs.");
        }

    }
}
