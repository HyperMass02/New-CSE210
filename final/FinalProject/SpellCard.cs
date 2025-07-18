public class SpellCard : Card
{
    private string _effect;
    private string _spellType;

    public SpellCard(string name, string attribute, string spellType, string effect)
        : base("Spell", name, attribute)
    {
        _effect = effect;
        _spellType = spellType;
    }

    public override void DisplayCard()
    {
        Console.WriteLine($"Type: Spell\nName: {GetName()}\nAttribute: {GetAttribute()}\nSpell Type: {_spellType}");
        Console.WriteLine($"Effect: {_effect}");
    }

    public override string GetCardData()
    {
        return $"Spell|{GetName()}|{GetAttribute()}|{_spellType}|{_effect}";
    }
}
