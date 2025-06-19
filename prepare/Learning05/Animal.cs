public class Animal
{
    private string _name;

    public Animal(string name)
    {
        _name = name;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Hello World!");
    }
}