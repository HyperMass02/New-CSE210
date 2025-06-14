using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listening Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing b = new Breathing();
                b.DisplayBreathing();
            }
            else if (choice == "2")
            {
                Reflection r = new Reflection();
                r.DisplayReflection();
            }
            else if (choice == "3")
            {
                Listing l = new Listing();
                l.DisplayListing();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");

            }
        }

       
    }
}