public class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public bool GoHunt()
    {
        return false;
    }
}