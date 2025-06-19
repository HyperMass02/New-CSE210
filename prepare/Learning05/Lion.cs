public class Lion : Animal
{
    public Lion(string name) : base(name)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }
}