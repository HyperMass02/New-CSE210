public class SpellCard : Card
{
    private string _effect;
    private string _spellType;

    public SpellCard(string name, string attribute, string spellType, string effect) : base("Spell", name, attribute)
    {

    }

    public override void DisplayCard()
    {

    }

    public override string  GetCardData()
    {
        return "NotImplementedException";
    }
}