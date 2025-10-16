using System;

interface Iswimmable
{
    void Swim();
}

class Fish : Iswimmable
{
    public string Name;

    public Fish(string name)
    {
        Name = name;
    }

    public void Swim() => Console.WriteLine($"{Name} is swimming");
}

class Program
{
    public static void Main()
    {
        List<Iswimmable> swimmingObjects = new List<Iswimmable>();
        swimmingObjects.Add((new Fish("Abborren")));
        swimmingObjects.Add(new Fish("Gäddan"));

        foreach (Iswimmable obj in swimmingObjects)
        {
            obj.Swim();
        }
    }
}