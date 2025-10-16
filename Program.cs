using System;

class Vehicle
{
    public string Brand;
    public Vehicle(string brand) { Brand = brand;}
  

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand} is attending.");
    }
    public virtual void Start()
    {
        Console.WriteLine(("Vehicles are starting..."));
    }
}

class Car : Vehicle
{
    public Car(string brand) : base(brand) { }

    public override void Start()
    {
        Console.WriteLine($"The {Brand} is starting and revving up his sportscar");
    }
}

class Truck : Vehicle
{
    public Truck(string brand) : base(brand) { }

    public override void Start()
    {
        Console.WriteLine($"Truck {Brand} is starting, this is a big one");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand) : base(brand) {  }
        
    public override void Start()
    {
        Console.WriteLine($"The {Brand} is starting to burn rubber!");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car("Ford"));
        vehicles.Add(new Motorcycle("Kawasaki"));
        vehicles.Add(new Car("Volvo"));
        vehicles.Add(new Truck("Toyota"));

        foreach (Vehicle a in vehicles)
        {
            a.Start();
        }
    }
}