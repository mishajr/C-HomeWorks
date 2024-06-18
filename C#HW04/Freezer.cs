using System;

public partial class Freezer
{

    private string brand;
    private double capacity;
    private int temperature;
    private bool isNoFrost;
    private string energyClass;


    public static string Category { get; private set; }
    public static int TotalFreezers { get; private set; }

 
    static Freezer()
    {
        Category = "Home Appliance";
        TotalFreezers = 0;
    }


    public Freezer()
    {
        brand = "Unknown";
        capacity = 0.0;
        temperature = -18;
        isNoFrost = false;
        energyClass = "A+";
        TotalFreezers++;
    }

    public Freezer(string brand, double capacity) : this()
    {
        this.brand = brand;
        this.capacity = capacity;
    }

    public Freezer(string brand, double capacity, int temperature, bool isNoFrost, string energyClass)
    {
        this.brand = brand;
        this.capacity = capacity;
        this.temperature = temperature;
        this.isNoFrost = isNoFrost;
        this.energyClass = energyClass;
        TotalFreezers++;
    }


    public override string ToString()
    {
        return $"Brand: {brand}, Capacity: {capacity}L, Temperature: {temperature}°C, No Frost: {isNoFrost}, Energy Class: {energyClass}";
    }
}
