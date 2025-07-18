public class FusionCard : MonsterCard
{
    private string _materials;

    public FusionCard(string name, string attribute, int level, int attack, int defense, string effect, string materials)
        : base(name, attribute, level, attack, defense, effect)
    {
        _materials = materials;
    }

    public override void DisplayCard()
    {
        Console.WriteLine($"Type: Fusion\nName: {GetName()}\nAttribute: {GetAttribute()}\nLevel: {GetLevel()}");
        Console.WriteLine($"Attack: {GetAttack()}\nDefense: {GetDefense()}\nEffect: {GetEffect()}");
        Console.WriteLine($"Materials: {_materials}");
    }

    public override string GetCardData()
    {
        return $"Fusion|{GetName()}|{GetAttribute()}|{GetLevel()}|{GetAttack()}|{GetDefense()}|{GetEffect()}|{_materials}";
    }
}
