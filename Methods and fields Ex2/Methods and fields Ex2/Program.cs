using System;
             // USED WITH USER INPUT! :D 
class Rectangle
{
    public double width;
    public double height;

    public double Area()
    {
        return width * height;
        Console.WriteLine($"The area is: {Area}");
    }

    public double Perimeter()
    {
        return 2 * (width + height);
        Console.WriteLine($"The perimiter is : {Perimeter()}");
       
    }

    class Program
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle();
            
            rect.width = double.Parse(Console.ReadLine());
            rect.height = double.Parse(Console.ReadLine());

            double area = rect.Area();
            double perimeter = rect.Perimeter();
            
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}