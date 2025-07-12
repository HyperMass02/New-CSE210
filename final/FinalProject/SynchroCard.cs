public class SynchroCard : Card
{
    private string _tunerRequirement  ;

    public SynchroCard(string name, int level, string attribute, string tunerRequirement, int attack, int defense, string effect) 
    : base("Synchro", name, attribute)
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