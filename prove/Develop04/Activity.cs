using System;

public class Activity
{
	private int _time;
	private string _activity;
	private string _description;

	public void SetTime(int time)
	{
		_time = time;
	}
	public int GetTime()
	{
		return _time;
	}

	public Activity(string activity, string description)
	{
		_activity = activity;
		_description = description;
	}

	public void StartingMessage()
	{
		Console.Clear();
		Console.WriteLine($"Welcome to the {_activity}");
		Console.WriteLine();
		Console.WriteLine(_description);
		Console.WriteLine();
		Console.Write("How long, in seconds, would you like for your session? ");
		SetTime(Int32.Parse(Console.ReadLine()));
	}

	protected void GetReady()
	{
		Console.Clear();
		Console.Write("Get Ready...");
		Spinner(60);
		Console.WriteLine();
	}

	protected void Spinner(int count)
	{
		while (count > 0)
		{
			Console.CursorVisible = false;

			Console.Write("| ");
			Thread.Sleep(150);
			count--;
			Console.Write("\b \b");
			Console.Write("\b \b");
			count--;
			
			Console.Write("/ ");
			Thread.Sleep(150);
			count--;
			Console.Write("\b \b");
			Console.Write("\b \b");
			count--;
			
			Console.Write("- ");
			Thread.Sleep(150);
			count--;
			Console.Write("\b \b");
			Console.Write("\b \b");
			count--;

			Console.Write("\\ ");
			Thread.Sleep(150);
			count--;
			Console.Write("\b \b");
			Console.Write("\b \b");
			count--;
		}
	}

	protected void EndingMessage()
	{
		Console.WriteLine();
		Console.WriteLine("Well done!");
		Console.WriteLine();
		Spinner(50);
		Console.WriteLine($"You have completed {_time} seconds of the {_activity}");
		Spinner(60);
	}
}