class Program
{
    static void Main()
    {
        RaceTeam team = new RaceTeam("Turbo Racing");

        team.AddDriver(new Driver("Kalle", 22, 9, 5));
        team.AddDriver(new Driver("Emma", 25, 8, 3));

        team.AddCar(new Car("Subaru Impreza", 300, 1200, "Rally"));
        team.AddCar(new Car("BMW GT3", 500, 1300, "GT"));

        team.PrintTeam();

        team.SaveToFile("team.txt");

        Console.WriteLine("\nTallennettu tiedostoon!");
    }
}
