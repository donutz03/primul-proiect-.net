using System;
using System.Collections.Generic;

enum CarSize
{
    Compact,
    SUV,
    Truck
}

abstract class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public abstract CarSize Size { get; }
}

class CompactCar : Vehicle
{
    public CompactCar(string make, string model) : base(make, model)
    {
    }

    public override CarSize Size => CarSize.Compact;
}

class SUV : Vehicle
{
    public SUV(string make, string model) : base(make, model)
    {
    }

    public override CarSize Size => CarSize.SUV;
}

class Truck : Vehicle
{
    public Truck(string make, string model) : base(make, model)
    {
    }

    public override CarSize Size => CarSize.Truck;
}

interface Parkable
{
    void Park();
    void Retrieve();
}

class ParkingSpace
{
    public CarSize Size { get; set; }
    public bool IsAvailable { get; set; }

    public ParkingSpace(CarSize size)
    {
        Size = size;
        IsAvailable = true;
    }
}

class ParkingLot
{
    private List<ParkingSpace> parkingSpaces;

    public ParkingLot()
    {
        parkingSpaces = new List<ParkingSpace>();
        InitializeParkingSpaces();
    }

    private void InitializeParkingSpaces()
    {
        parkingSpaces.Add(new ParkingSpace(CarSize.Compact));
        parkingSpaces.Add(new ParkingSpace(CarSize.Compact));
        parkingSpaces.Add(new ParkingSpace(CarSize.SUV));
        parkingSpaces.Add(new ParkingSpace(CarSize.Truck));
    }

    public void AddCar(Vehicle vehicle)
    {
        Parkable parkableVehicle = vehicle as Parkable;
        if (parkableVehicle != null)
        {
            parkableVehicle.Park();
        }
        else
        {
            Console.WriteLine("Cannot park the car. It does not implement the Parkable interface.");
        }
    }

    public void RetrieveCar(Vehicle vehicle)
    {
        Parkable parkableVehicle = vehicle as Parkable;
        if (parkableVehicle != null)
        {
            parkableVehicle.Retrieve();
        }
        else
        {
            Console.WriteLine("Cannot retrieve the car. It does not implement the Parkable interface.");
        }
    }

    public void DisplayParkingStatus()
    {
        int availableSpaces = 0;
        int parkedCars = 0;

        foreach (var space in parkingSpaces)
        {
            if (space.IsAvailable)
                availableSpaces++;
            else
                parkedCars++;
        }

        Console.WriteLine("Parking Spaces:");
        Console.WriteLine($"Available Spaces: {availableSpaces}");
        Console.WriteLine($"Parked Cars: {parkedCars}");
    }
}

class CarApp
{
    static void Main(string[] args)
    {
        ParkingLot parkingLot = new ParkingLot();

        CompactCar compactCar = new CompactCar("Honda", "Civic");
        parkingLot.AddCar(compactCar);

        SUV suv = new SUV("Toyota", "RAV4");
        parkingLot.AddCar(suv);

        Truck truck = new Truck("Ford", "F-150");
        parkingLot.AddCar(truck);

        parkingLot.DisplayParkingStatus();

        Console.ReadLine();
    }
}