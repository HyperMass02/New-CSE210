public class ChecklistGoal : Goal
{
    private int _times;
    private int _done;

    public ChecklistGoal(string name, int points, int times, int done = 0) : base(name, points)
    {
        _times = times;
        _done = done;
    }

    public override void Record(ref int totalPoints)
    {
        if (_done < _times)
        {
            _done++;
            totalPoints += _points;
        }
    }

    public override void Show()
    {
        string status = _done >= _times ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_done}/{_times})");
    }

    public override string SaveFormat()
    {
        return $"Checklist|{_name}|{_points}|{_times}|{_done}";
    }
}
