using System;

public class BreathingActivity : Activity
{
	private int _breaths;

	public BreathingActivity(string activity, string description) : base(activity, description)
	{
		base.StartingMessage();
		_breaths = base.GetTime() / 4;
		StartActivity();
	}

	private void Countdown()
	{
		Console.CursorVisible = false;
		int seconds = 4;

		while (seconds > 0)
		{
			Console.Write(seconds + " ");
			seconds--;
			Thread.Sleep(1050);
			Console.Write("\b \b");
			Console.Write("\b \b");
		}
	}

	public void StartActivity()
	{
		base.GetReady();
		Console.WriteLine();
		while (_breaths > 0)
		{
			Console.Write("Breath in... ");
			Countdown();
			Console.WriteLine();
			_breaths--;
			Console.WriteLine();
			Console.Write("Breath out... ");
			Countdown();
			Console.WriteLine();
			_breaths--;
			Console.WriteLine();
		}

		base.EndingMessage();
	}
}