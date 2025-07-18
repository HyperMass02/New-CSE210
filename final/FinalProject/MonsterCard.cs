public class MonsterCard : Card
{
    private int _attack;
    private int _defense;
    private string _effect;
    private int _level;

    public MonsterCard(string name, string attribute, int level, int attack, int defense, string effect)
        : base("Monster", name, attribute)
    {
        _attack = attack;
        _defense = defense;
        _effect = effect;
        _level = level;
    }

    public int GetAttack() => _attack;
    public int GetDefense() => _defense;
    public string GetEffect() => _effect;
    public int GetLevel() => _level;

    public override void DisplayCard()
    {
        base.DisplayCard();
        Console.WriteLine($"Level: {_level}\nAttack: {_attack}\nDefense: {_defense}\nEffect: {_effect}");
    }

    public override string GetCardData()
    {
        return $"Monster|{GetName()}|{GetAttribute()}|{_level}|{_attack}|{_defense}|{_effect}";
    }
}
