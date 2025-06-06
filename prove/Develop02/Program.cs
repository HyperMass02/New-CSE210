using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)  
    {
        string choice = "";
        List<Journal> journalEntries = new List<Journal>();
        string filename = "journal.txt";

        while (choice != "5")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. View journal entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please enter the title of your journal entry:");
                string title = Console.ReadLine();

                Console.WriteLine("Please enter the content of your journal entry:");
                string journal = Console.ReadLine();

                string promptText = Prompt.DisplayPrompt();
                Console.WriteLine($"Please answer the following prompt:\n {promptText}");
                string promptAnswer = Console.ReadLine();

                DateTime date = DateTime.Now;

                Journal newJournal = new Journal
                {
                    title = title,
                    journal = journal,
                    date = date,
                    prompt = promptAnswer
                };

                journalEntries.Add(newJournal);
                Console.WriteLine("Entry saved in memory!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                if (journalEntries.Count == 0)
                {
                    Console.WriteLine("No entries available.");
                }
                else
                {
                    foreach (var entry in journalEntries)
                    {
                        entry.Display();
                    }
                }
            }
            else if (choice == "3")
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in journalEntries)
                    {
                        writer.WriteLine(entry.ToTextBlock());
                    }
                }
                Console.WriteLine("Entries saved to text file.");
            }
            else if (choice == "4")
            {
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    journalEntries.Clear();
                    for (int i = 0; i < lines.Length; i += 5)  // 4 lines + separator
                    {
                        if (i + 3 < lines.Length)
                        {
                            string[] entryLines = new string[] { lines[i], lines[i + 1], lines[i + 2], lines[i + 3] };
                            journalEntries.Add(Entry.FromTextBlock(entryLines));
                        }
                    }
                    Console.WriteLine("Entries loaded from text file.");
                }
                else
                {
                    Console.WriteLine("No journal file found.");
                }
            }
            else if (choice == "5")
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
