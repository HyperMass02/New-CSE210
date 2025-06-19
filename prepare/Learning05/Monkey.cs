public class Monkey : Animal
{
    public Monkey(string name) : base(name)
    {

    }
    
     public override void MakeSound()
    {
        Console.WriteLine("ooh ooh aah aah");
    }
}