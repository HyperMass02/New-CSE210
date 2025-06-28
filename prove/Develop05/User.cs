using System;
using System.Collections.Generic;
using System.IO;

public class User
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    public void Add(Goal g) => _goals.Add(g);

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Show();
        }
    }

    public void RecordGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].Record(ref _points);
        }
    }

    public void ShowPoints()
    {
        Console.WriteLine($"Points: {_points}");
    }

    public void Save(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_points);
            foreach (Goal g in _goals)
                writer.WriteLine(g.SaveFormat());
        }
    }

    public void Load(string file)
    {
        if (!File.Exists(file)) return;

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _points = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            if (parts[0] == "Simple")
                _goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
            else if (parts[0] == "Eternal")
                _goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
            else if (parts[0] == "Checklist")
                _goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
        }
    }
}
