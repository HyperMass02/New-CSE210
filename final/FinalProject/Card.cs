public abstract class Card
{
    protected string _type;
    protected string _name;
    protected string _attribute;

    public Card(string type, string name, string attribute)
    {
        _type = type;
        _name = name;
        _attribute = attribute;
    }

    public string GetName() => _name;
    public string GetAttribute() => _attribute;
    public string GetTypeName() => _type;

    public virtual void DisplayCard()
    {
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Attribute: {_attribute}");
    }

    public abstract string GetCardData();
}
