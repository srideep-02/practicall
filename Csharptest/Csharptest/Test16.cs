
using System;

abstract class Vehicle1
{
    public abstract void Drive();
}

class Car1 : Vehicle1
{
    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

class Bike1 : Vehicle1
{
    public override void Drive()
    {
        Console.WriteLine("Bike is driving...");
    }
}

class VehicleFactory
{
    public static Vehicle1 GetVehicle(string type)
    {
        if (type == "Car")
        {
            return new Car1();
        }
        else if (type == "Bike")
        {
            return new Bike1();
        }
        else
        {
            throw new ArgumentException("Invalid vehicle type");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Vehicle1 vehicle1 = VehicleFactory.GetVehicle("Car");
            vehicle1.Drive();

            Vehicle1 vehicle2 = VehicleFactory.GetVehicle("Bike");
            vehicle2.Drive();

         
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
