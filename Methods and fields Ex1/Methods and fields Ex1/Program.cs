using System;

class Lamp
{
    public bool isOn;
    
    //Method to turn it On
    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Lamp is On!");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Lamp is Off!");
    }

    public void Toggle()
    {
        isOn = !isOn;
        if (isOn)
            Console.WriteLine("Lamp is ON.");
        else
            Console.WriteLine("Lamp is OFF.");
    }
}

class Program
    {
        static void Main()
        {

            Lamp myLamp = new Lamp();
            
            myLamp.TurnOn();
            myLamp.Toggle();
            myLamp.Toggle();
            myLamp.TurnOff();
            
            Console.WriteLine($"Is the lamp on? {myLamp}");
            
            myLamp.Toggle();
            
            Console.WriteLine($"Is the lamp on? {myLamp}");
            
            myLamp.Toggle();
            
            Console.WriteLine($"Is the lamp on? {myLamp}");
            
            
        }
    }
