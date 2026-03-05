public class Driver : IRaceParticipant
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int SkillLevel { get; set; }
    public int Wins { get; set; }

    public Driver(string name, int age, int skillLevel, int wins)
    {
        Name = name;
        Age = age;
        SkillLevel = skillLevel;
        Wins = wins;
    }

    public int GetPerformance()
    {
        return SkillLevel;
    }

    public override string ToString()
    {
        return $"{Name} skill {SkillLevel}";
    }
}
