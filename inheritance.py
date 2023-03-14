class Animal:
    def __init__(self, numberOfLegs, color, age) -> None:
        self.numberOfLegs = numberOfLegs
        self.color = color
        self.age = age

    def run(self):
        print("This animal is running on " + self.numberOfLegs + " legs.")


class Pet(Animal):
    def __init__(self, numberOfLegs, color, age, name, owner) -> None:
        super().__init__(self, numberOfLegs, color, age)
        self.name = name
        self.owner = owner

    def printInfo(self):
        print(self.name + " is owned by " + self.owner)


class Dog(Pet):
    def __init__(self, numberOfLegs, color, age, name, owner, breed) -> None:
        super().__init__(self, numberOfLegs, color, age, name, owner)
        self.breed = breed

    def bark(self):
        print("Woof woof!")

    def run(self):
        print("This dog is running on " + self.numberOfLegs + " legs.")




