using System;

class Program
{
    static void Main(string[] args)
    {
        CardManager manager = new CardManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nYu-Gi-Oh Card Manager");
            Console.WriteLine("1. Add Card");
            Console.WriteLine("2. Display All Cards");
            Console.WriteLine("3. Save Cards");
            Console.WriteLine("4. Load Cards");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter card type (monster, xyz, spell, trap, fusion, synchro): ");
                string type = Console.ReadLine().ToLower();
                manager.AddCard(type);
            }
            else if (input == "2")
            {
                manager.DisplayAllCards();
            }
            else if (input == "3")
            {
                manager.SaveToFile("cards.txt");
                Console.WriteLine("Cards saved.");
            }
            else if (input == "4")
            {
                manager.LoadFromFile("cards.txt");
            }
            else if (input == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
