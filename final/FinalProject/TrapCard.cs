public class TrapCard : Card
{
    private string _effect;
    private string _trapType;

    public TrapCard(string name, string attribute, string trapTypeType, string effect) : base("Trap", name, attribute)
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