var opel = new Car("Opel", "Insignia", 55, 5.5);
opel.AddFuel(10);
Console.WriteLine($"The car is {opel.Brand} {opel.Model} and it has {opel.FuelLevel}");
opel.AddFuel(60);
Console.WriteLine($"The car is {opel.Brand} {opel.Model} and it has {opel.FuelLevel}");

opel.Drive(100);
Console.WriteLine($"The car is {opel.Brand} {opel.Model} and it has {opel.FuelLevel} {opel.Odometer}");
opel.Drive(2000);
Console.WriteLine($"The car is {opel.Brand} {opel.Model} and it has {opel.FuelLevel} {opel.Odometer}");

public class Car
{
    private readonly string _brand;
    private readonly string _model;
    private readonly int _tankCapacity;
    private readonly double _fuelConsumption;
    
    private double _fuelLevel;
    private double _odometer;

    public string Brand => _brand;
    public string Model => _model;
    public int FuelLevel => (int)_fuelLevel;
    public int Odometer => (int)_odometer;

    public void Drive(double distance)
    {
        if (distance < 0)
            throw new InvalidOperationException("Distance cannot be negative");

        var maxDistance = _fuelLevel / _fuelConsumption * 100;

        if (distance <= maxDistance)
        {
            _odometer += distance;
            _fuelLevel -= distance * _fuelConsumption / 100;
        }
        else
        {
            _odometer += maxDistance;
            _fuelLevel = 0;
        }
    }

    public void AddFuel(double fuel)
    {
        if (fuel < 0)
            throw new InvalidOperationException("Fuel cannot be negative");
        
        _fuelLevel += fuel;

        if (_fuelLevel > _tankCapacity)
            _fuelLevel = _tankCapacity;
    }

    public Car(string brand, string model, int tankCapacity, double fuelConsumption)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "Provide a valid brand");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "Provide a valid model");

        if (tankCapacity <= 0)
            throw new ArgumentException("Tank capacity must be positive", nameof(tankCapacity));

        if (fuelConsumption <= 0)
            throw new ArgumentException("Fuel consumption must be positive", nameof(fuelConsumption));

        _brand = brand;
        _model = model;
        _fuelConsumption = fuelConsumption;
        _tankCapacity = tankCapacity;
    }
}