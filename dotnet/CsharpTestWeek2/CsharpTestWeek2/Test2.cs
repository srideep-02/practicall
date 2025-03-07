using System;
public class Vehicles
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicles(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

public class Cars : Vehicles
{
    public int NumberOfDoors { get; set; }

    public Cars(string brand, int speed, int numberOfDoors) : base(brand, speed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Car Specific Info: Number of Doors: {NumberOfDoors}");
    }
}

public class Bikes : Vehicles
{
    public bool HasGear { get; set; }

    public Bikes(string brand, int speed, bool hasGear) : base(brand, speed)
    {
        HasGear = hasGear;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Bike Specific Info: Has Gear: {HasGear}");
    }
}

