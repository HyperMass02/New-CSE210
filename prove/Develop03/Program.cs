using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", "3", 5, 6);
        string verse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, verse);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                return;


            scripture.HideWords(3);
        }

        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine("\nAll words are now hidden. Program ended.");
    }
}
