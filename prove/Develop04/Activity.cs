public class Activity
{
    private string _startMessage;
    private string _activityName;
    protected int _activityDuration;

    private string _activityDescription;

    public Activity(string startmessage, string name, int duration, string description)
    {
        _startMessage = startmessage;
        _activityName = name;
        _activityDuration = duration;
        _activityDescription = description;
    }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine(_activityDescription);
        Console.Write("Enter the duration in seconds: ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3, 3);
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void Pause(int time, int type)
    {
        if (type == 1)
        {
            DisplayLoadingIcon(time);
        }
        else if (type == 2)
        {
            DisplayLoadingNumbers(time);
        }
        else if (type == 3)
        {
            DisplayLoadingDots(time);
        }
        else
        {
            for (int i = time; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!");
        Pause(3, 3);
        Console.WriteLine($"You have completed {_activityName} for {_activityDuration} seconds.");
        Pause(2, 3);
    }
    private void DisplayLoadingIcon(int time)
    {
         string[] spinner = { "/", "-", "\\", "|" };
        for (int i = 0; i < time * 4; i++) // Show for approx. `time` seconds
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();


    }

    private void DisplayLoadingNumbers(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void DisplayLoadingDots(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
    
}