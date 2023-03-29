using System;

public class Outdoor : Event
{
	private string _weather;

	public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
	{
		_weather = weather;
	}

	public string GetWeather()
	{
		return _weather;
	}

	public void FullDetails()
	{
		base.StandardDetails();
		Console.WriteLine($"Weather this day will be: {GetWeather()}");
        Console.WriteLine();
	}
	public void ShortDetails()
	{
		Console.WriteLine($"{this.GetType().Name} Event");
		base.ShortDet();
        Console.WriteLine();
	}
}