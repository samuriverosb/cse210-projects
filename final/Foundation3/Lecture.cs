using System;

public class Lecture : Event
{
	private string _speaker;
	private int _capacity;

	public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
	{
		_speaker = speaker;
		_capacity = capacity;
	}

	public string GetSpeaker()
	{
		return _speaker;
	}
	public int GetCapacity()
	{
		return _capacity;
	}

	public void FullDetails()
	{
		base.StandardDetails();
		Console.WriteLine($"Speaker: {GetSpeaker()}. Room capacity: {GetCapacity()}");
        Console.WriteLine();
	}

	public void ShortDetails()
	{
		Console.WriteLine($"{this.GetType().Name} Event");
		base.ShortDet();
        Console.WriteLine();
	}
}