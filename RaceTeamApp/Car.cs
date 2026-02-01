public class Car
{
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public int Weight { get; set; }
    public string Class { get; set; }

    public Car(string model, int horsePower, int weight, string carClass)
    {
        Model = model;
        HorsePower = horsePower;
        Weight = weight;
        Class = carClass;
    }

    public double PowerToWeightRatio() =>
        (double)HorsePower / Weight;

    public override string ToString() =>
        $"{Model}, {HorsePower}hp, {Weight}kg, Luokka: {Class}";
}
