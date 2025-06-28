public abstract class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract void Record(ref int totalPoints);
    public abstract void Show();
    public abstract string SaveFormat();
}
