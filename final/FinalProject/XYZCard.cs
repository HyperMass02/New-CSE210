public class XYZCard : Card
{
    private int _rank;

    public XYZCard(string name, string attribute, int rank, int attack, int defense, string effect) : base("XYZ", name, attribute)
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