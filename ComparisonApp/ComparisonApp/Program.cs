using System;

namespace ComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal test = new Animal(4, "brown", 6);
            test.run();

            Pet pet1 = new Pet(2, "Red", 50, "Charlie", "Maria");
            Pet pet2 = pet1;
            pet1.run();
            pet2.printInfo();
            pet1.changeOwner("Hammy");
            pet2.printInfo();

            Dog dog = new Dog(4, "Black and white", 2, "Musti", "Maria", "Dalmatian");
            dog.run();
            dog.bark();
            dog.printInfo();

        }
    }
}
