using System;
using System.Collections.Generic;
using System.IO;

public class CardManager
{
    private List<Card> _cards = new List<Card>();

    public void AddCard(string type)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Attribute: ");
        string attribute = Console.ReadLine();

        if (type == "monster")
        {
            Console.Write("Enter Level: ");
            int level = int.Parse(Console.ReadLine());

            Console.Write("Enter Attack: ");
            int attack = int.Parse(Console.ReadLine());

            Console.Write("Enter Defense: ");
            int defense = int.Parse(Console.ReadLine());

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new MonsterCard(name, attribute, level, attack, defense, effect));
        }
        else if (type == "spell")
        {
            Console.Write("Enter Spell Type: ");
            string spellType = Console.ReadLine();

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new SpellCard(name, attribute, spellType, effect));
        }
        else if (type == "trap")
        {
            Console.Write("Enter Trap Type: ");
            string trapType = Console.ReadLine();

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new TrapCard(name, attribute, trapType, effect));
        }
                else if (type == "xyz")
        {
            Console.Write("Enter Rank: ");
            int rank = int.Parse(Console.ReadLine());

            Console.Write("Enter Attack: ");
            int attack = int.Parse(Console.ReadLine());

            Console.Write("Enter Defense: ");
            int defense = int.Parse(Console.ReadLine());

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new XYZCard(name, attribute, rank, attack, defense, effect));
        }
         else if (type == "fusion")
        {
            Console.Write("Enter Level: ");
            int level = int.Parse(Console.ReadLine());

            Console.Write("Enter Attack: ");
            int attack = int.Parse(Console.ReadLine());

            Console.Write("Enter Defense: ");
            int defense = int.Parse(Console.ReadLine());

            Console.Write("Enter Fusion Materials: ");
            string materials = Console.ReadLine();

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new FusionCard(name, level, attribute, materials,attack ,defense, effect));
        }
        else if (type == "synchro")
        {
            Console.Write("Enter Level: ");
            int level = int.Parse(Console.ReadLine());

            Console.Write("Enter Attack: ");
            int attack = int.Parse(Console.ReadLine());

            Console.Write("Enter Defense: ");
            int defense = int.Parse(Console.ReadLine());

            Console.Write("Enter Tuner Requirement: ");
            string tunerRequirement = Console.ReadLine();

            Console.Write("Enter Effect: ");
            string effect = Console.ReadLine();

            _cards.Add(new SynchroCard(name, level, attribute, tunerRequirement, attack, defense, effect));
        }
        else
        {
            Console.WriteLine("Unknown card type.");
        }
    }

    public void DisplayAllCards()
    {
        foreach (Card card in _cards)
        {
            card.DisplayCard();
            Console.WriteLine("--------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Card card in _cards)
            {
                writer.WriteLine(card.GetCardData());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _cards.Clear();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "Monster")
            {
                _cards.Add(new MonsterCard(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), parts[6]));
            }
            else if (type == "XYZ")
            {
                _cards.Add(new XYZCard(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), parts[6]));
            }
            else if (type == "Spell")
            {
                _cards.Add(new SpellCard(parts[1], parts[2], parts[3], parts[4]));
            }
            else if (type == "Trap")
            {
                _cards.Add(new TrapCard(parts[1], parts[2], parts[3], parts[4]));
            }
        }

        Console.WriteLine("Cards loaded successfully.");
    }
}
