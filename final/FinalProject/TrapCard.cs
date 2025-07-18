public class TrapCard : Card
{
    private string _effect;
    private string _trapType;

    public TrapCard(string name, string attribute, string trapType, string effect)
        : base("Trap", name, attribute)
    {
        _effect = effect;
        _trapType = trapType;
    }

    public override void DisplayCard()
    {
        Console.WriteLine($"Type: Trap\nName: {GetName()}\nAttribute: {GetAttribute()}\nTrap Type: {_trapType}");
        Console.WriteLine($"Effect: {_effect}");
    }

    public override string GetCardData()
    {
        return $"Trap|{GetName()}|{GetAttribute()}|{_trapType}|{_effect}";
    }
}
