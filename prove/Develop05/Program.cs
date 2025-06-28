using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        bool done = false;

        while (!done)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Points");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal(user);
            }
            else if (input == "2")
            {
                user.ShowGoals();
            }
            else if (input == "3")
            {
                user.ShowGoals();
                Console.Write("Enter goal number to record: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                user.RecordGoal(index);
            }
            else if (input == "4")
            {
                user.ShowPoints();
            }
            else if (input == "5")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                user.Save(filename);
            }
            else if (input == "6")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                user.Load(filename);
            }
            else if (input == "7")
            {
                done = true;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void CreateGoal(User user)
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            user.Add(new SimpleGoal(name, points));
        }
        else if (type == "2")
        {
            user.Add(new EternalGoal(name, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete? ");
            int times = int.Parse(Console.ReadLine());
            user.Add(new ChecklistGoal(name, points, times));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
}
