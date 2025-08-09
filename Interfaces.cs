using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    void IMovable.Move()
    {
        Console.WriteLine("Car is moving");
    }

    public void Drive()
    {
        Console.WriteLine("Driving the car");
    }
}

class Bicycle : IMovable
{
    void IMovable.Move()
    {
        Console.WriteLine("Bicycle is moving");
    }

    public void Pedal()
    {
        Console.WriteLine("Pedaling the bicycle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();       
        bicycle.Move();   

        
        ((Car)car).Drive();         
        ((Bicycle)bicycle).Pedal();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
