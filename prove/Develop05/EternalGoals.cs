public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void Record(ref int totalPoints)
    {
        totalPoints += _points;
    }

    public override void Show()
    {
        Console.WriteLine($"[∞] {_name}");
    }

    public override string SaveFormat()
    {
        return $"Eternal|{_name}|{_points}";
    }
}
