public class Car : Vehicle
{
    public string Brand { get; set; }

    public Car(string brand, string model, int horsePower, int weight)
        : base(model, horsePower, weight)
    {
        Brand = brand;
    }

    public override string GetInfo()
    {
        return $"{Brand} {Model} - {HorsePower}hp";
    }
}