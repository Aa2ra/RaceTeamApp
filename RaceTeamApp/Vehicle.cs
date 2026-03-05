public class Vehicle
{
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public int Weight { get; set; }

    public Vehicle(string model, int hp, int weight)
    {
        Model = model;
        HorsePower = hp;
        Weight = weight;
    }

    public virtual string GetInfo()
    {
        return $"{Model} {HorsePower}hp {Weight}kg";
    }
}