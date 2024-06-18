public partial class Freezer
{
    public string Brand { get; set; }

    public double Capacity { get; set; }
    public int Temperature
    {
        get { return temperature; }
        set
        {
            if (value <= 0 && value >= -30)
            {
                temperature = value;
            }
            else
            {
                throw new ArgumentException("Temperature should be between -30°C and 0°C.");
            }
        }
    }

    public bool IsNoFrost { get; set; }


    public int EnergyClass { get; set; }



    public void DisplayInfo()
    {
        Console.WriteLine(this.ToString());
    }
}
