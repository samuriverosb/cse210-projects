using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 5.6);
        Cycling cycling = new Cycling(20, 12.3);
        Swimming swimming = new Swimming(25, 50);

        List<Activity> list = new List<Activity>();
        list.Add(running);
        list.Add(cycling);
        list.Add(swimming);

        Console.Clear();
        foreach(Activity activity in list)
        {
            activity.CalculateDistance();
            activity.CalculateSpeed();
            activity.CalculatePace();
            activity.GetSummary();
        }
    }
}