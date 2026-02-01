using System;
using System.Collections.Generic;
using System.IO;

public class RaceTeam
{
    public string TeamName { get; set; }
    public List<Driver> Drivers { get; set; } = new();
    public List<Car> Cars { get; set; } = new();

    public RaceTeam(string teamName) => TeamName = teamName;

    public void AddDriver(Driver d) => Drivers.Add(d);
    public void AddCar(Car c) => Cars.Add(c);

    public void PrintTeam()
    {
        Console.WriteLine($"=== {TeamName} ===");

        Console.WriteLine("Kuljettajat:");
        Drivers.ForEach(d => Console.WriteLine(d));

        Console.WriteLine("\nAutot:");
        Cars.ForEach(c => Console.WriteLine(c));
    }

    public void SaveToFile(string path)
    {
        using StreamWriter sw = new(path);

        foreach (var d in Drivers)
            sw.WriteLine($"DRIVER;{d.Name};{d.Age};{d.SkillLevel};{d.Wins}");

        foreach (var c in Cars)
            sw.WriteLine($"CAR;{c.Model};{c.HorsePower};{c.Weight};{c.Class}");
    }

    public void LoadFromFile(string path)
    {
        Drivers.Clear();
        Cars.Clear();

        foreach (var line in File.ReadAllLines(path))
        {
            var p = line.Split(';');

            if (p[0] == "DRIVER")
                Drivers.Add(new Driver(p[1], int.Parse(p[2]), int.Parse(p[3]), int.Parse(p[4])));
            else if (p[0] == "CAR")
                Cars.Add(new Car(p[1], int.Parse(p[2]), int.Parse(p[3]), p[4]));
        }
    }
}
