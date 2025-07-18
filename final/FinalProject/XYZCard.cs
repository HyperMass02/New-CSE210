public class XYZCard : MonsterCard
{
    private int _rank;

    public XYZCard(string name, string attribute, int rank, int attack, int defense, string effect)
        : base(name, attribute, 0, attack, defense, effect)
    {
        _rank = rank;
    }

    public override void DisplayCard()
    {
        Console.WriteLine($"Type: XYZ\nName: {GetName()}\nAttribute: {GetAttribute()}\nRank: {_rank}");
        Console.WriteLine($"Attack: {GetAttack()}\nDefense: {GetDefense()}\nEffect: {GetEffect()}");
    }

    public override string GetCardData()
    {
        return $"XYZ|{GetName()}|{GetAttribute()}|{_rank}|{GetAttack()}|{GetDefense()}|{GetEffect()}";
    }
}
