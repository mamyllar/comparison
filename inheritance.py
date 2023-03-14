class Animal:
    def __init__(self, numberOfLegs, color, age) -> None:
        self.numberOfLegs = numberOfLegs
        self.color = color
        self.age = age

    def run(self):
        print("This animal is running on " + str(self.numberOfLegs) + " legs.")


class Pet(Animal):
    def __init__(self, numberOfLegs, color, age, name, owner) -> None:
        super().__init__(numberOfLegs, color, age)
        self.name = name
        self.owner = owner

    def printInfo(self):
        print(self.name + " is owned by " + self.owner)

    def changeOwner(self, newOwner):
        self.owner = newOwner
        print("The new owner of " + self.name + " is " + self.owner)


class Dog(Pet):
    def __init__(self, numberOfLegs, color, age, name, owner, breed) -> None:
        super().__init__(numberOfLegs, color, age, name, owner)
        self.breed = breed

    def bark(self):
        print("Woof woof!")

    def run(self):
        print("This dog is running on " + str(self.numberOfLegs) + " legs.")

animal = Animal(4, "brown", 6)
animal.run()

pet1 = Pet(2, "Red", 50, "Charlie", "Maria")
pet2 = pet1
pet1.run()
pet2.printInfo()
pet1.changeOwner("Hammy")
pet2.printInfo()

dog = Dog(4, "Black and white", 2, "Musti", "Maria", "Dalmatian")
dog.run()
dog.bark()
dog.printInfo()


