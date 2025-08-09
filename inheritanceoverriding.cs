using System;

class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Animal animalDog = new Dog();
        Animal animalCat = new Cat();

        genericAnimal.MakeSound();  
        animalDog.MakeSound();      
        animalCat.MakeSound();      

        ((Dog)animalDog).MakeSound();  
        ((Cat)animalCat).MakeSound();  

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
