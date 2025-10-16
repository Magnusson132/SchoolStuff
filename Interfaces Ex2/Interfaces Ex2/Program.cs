using System;
using System.Collections.Generic;

interface IDrawable
{
    void Draw(); 
    
}

class Circle :  IDrawable
{
    public string Name;
    public int Sides = 0;

    public Circle(string name)
    {
        Name = name;
    }
    public void Draw() => Console.WriteLine($"{Name} is a round thingy, with {Sides} sides");
}
class Rectangle :  IDrawable
{
    public string Name;
    public int Sides = 4;
    
    public Rectangle(string name)
    {
        Name = name;
    }
    public void Draw() => Console.WriteLine($"{Name} is a square thingy, with {Sides} sides");
}
class Triangle :  IDrawable
{
    public string Name;
    public int Sides = 3;

    public Triangle(string name)
    {
        Name = name;
    }
    public void Draw() => Console.WriteLine($"{Name} is a pyramid thingy, with {Sides} sides");
}

class Program
{
    public static void Main()
    {
        List< IDrawable> objects = new List< IDrawable>();
        objects.Add(new Circle("Rundaringen"));
        objects.Add(new Rectangle("Fyrkanten"));
        objects.Add(new Triangle("Pyramiden"));

        foreach (IDrawable obj in objects)
        {
            obj.Draw();
        }
    }
}