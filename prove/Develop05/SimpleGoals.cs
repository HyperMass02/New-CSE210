public class SimpleGoal : Goal
{
    private bool _done;

    public SimpleGoal(string name, int points, bool done = false) : base(name, points)
    {
        _done = done;
    }

    public override void Record(ref int totalPoints)
    {
        if (!_done)
        {
            _done = true;
            totalPoints += _points;
        }
    }

    public override void Show()
    {
        string status = _done ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name}");
    }

    public override string SaveFormat()
    {
        return $"Simple|{_name}|{_points}|{_done}";
    }
}
