public class FusionCard : Card
{
    private string _materials ;
    public FusionCard(string name,int level, string attribute, string materials, int attack, int defense, string effect)
    : base("Fusion", name, attribute)
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