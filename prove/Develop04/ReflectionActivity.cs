using System;

public class ReflectionActivity : Activity
{
	private List<string> _startingMessage = new List<string>();
	private List<string> _questions = new List<string>();
	private int _numberOfQuestions;

	private void PopulateLists()
	{
		_startingMessage.Add("Think of a time when you stood up for someone else.");
        _startingMessage.Add("Think of a time when you did something really difficult.");
        _startingMessage.Add("Think of a time when you helped someone in need.");
        _startingMessage.Add("Think of a time when you did something truly selfless.");

		_questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
	}

	public ReflectionActivity(string activity, string description) : base(activity, description)
	{
		PopulateLists();
		base.StartingMessage();
		_numberOfQuestions = base.GetTime() / 15;
		StartActivity();
	}

	private string RandomStart()
	{
		Random random = new Random();
		int randomIndex = random.Next(0, _startingMessage.Count);
		string start = _startingMessage[randomIndex];

		return start;
	}

	private string RandomQuestion()
	{
		Random random = new Random();
		int randomIndex = random.Next(0, _questions.Count);
		string question = _questions[randomIndex];

		return question;
	}

	private void StartActivity()
	{
		base.GetReady();
		Console.WriteLine();
		Console.WriteLine("Consider the following prompt:");
		Console.WriteLine();
		Console.WriteLine($"--- {RandomStart()} ---");
		Console.WriteLine();
		Console.WriteLine("When you have something in mind, press Enter to continue.");
		Console.WriteLine();
		Console.ReadLine();
		Console.Clear();
		while(_numberOfQuestions > 0)
		{
			Console.Write($"> {RandomQuestion()} ");
			base.Spinner(190);
			_numberOfQuestions--;
			Console.WriteLine();
		}
		Console.WriteLine();
		base.EndingMessage();
	}
}