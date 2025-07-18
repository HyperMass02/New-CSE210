public class SynchroCard : MonsterCard
{
    private string _tunerRequirement;

    public SynchroCard(string name, string attribute, int level, int attack, int defense, string effect, string tunerRequirement)
        : base(name, attribute, level, attack, defense, effect)
    {
        _tunerRequirement = tunerRequirement;
    }

    public override void DisplayCard()
    {
        Console.WriteLine($"Type: Synchro\nName: {GetName()}\nAttribute: {GetAttribute()}\nLevel: {GetLevel()}");
        Console.WriteLine($"Attack: {GetAttack()}\nDefense: {GetDefense()}\nEffect: {GetEffect()}");
        Console.WriteLine($"Tuner Requirement: {_tunerRequirement}");
    }

    public override string GetCardData()
    {
        return $"Synchro|{GetName()}|{GetAttribute()}|{GetLevel()}|{GetAttack()}|{GetDefense()}|{_tunerRequirement}|{GetEffect()}";
    }
}
