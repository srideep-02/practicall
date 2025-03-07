using System;

// Base class
class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

// Derived class - Car
class Car : Vehicle
{
    public string FuelType { get; set; }

    public Car(string brand, int speed, string fuelType) : base(brand, speed)
    {
        FuelType = fuelType;
    }

    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

// Derived class - Bike
class Bike : Vehicle
{
    public string TypeOfBike { get; set; }

    public Bike(string brand, int speed, string typeOfBike) : base(brand, speed)
    {
        TypeOfBike = typeOfBike;
    }

    public void DisplayBikeInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Type: {TypeOfBike}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 180, "Petrol");
        Bike bike = new Bike("Yamaha", 120, "Sport");

        Console.WriteLine("Car Details:");
        car.DisplayCarInfo();

        Console.WriteLine("\nBike Details:");
        bike.DisplayBikeInfo();
    }
}
