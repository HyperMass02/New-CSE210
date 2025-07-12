public abstract class Card
{
    private string _type;
    private string _name;
    private string _attribute;

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
        Console.WriteLine($"Type: {_type}\nName: {_name}\nAttribute: {_attribute}");
    }

    public abstract string GetCardData();
}
