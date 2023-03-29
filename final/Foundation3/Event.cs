using System;

public class Event
{
	private string _title;
	private string _description;
	private string _date;
	private string _time;
	private Address _address;

	public Event(string title, string description, string date, string time, Address address)
	{
		_title = title;
		_description = description;
		_date = date;
		_time = time;
		_address = address;
	}

	public string GetTitle()
	{
		return _title;
	}
	public string GetDescription()
	{
		return _description;
	}
	public string GetDate()
	{
		return _date;
	}
	public string GetTime()
	{
		return _time;
	}
	public Address GetAddress()
	{
		return _address;
	}

	public void StandardDetails()
	{
		Console.WriteLine();
		Console.WriteLine($"Title: {GetTitle()}");
		Console.WriteLine($"Description: {GetDescription()}");
		Console.WriteLine($"Date: {GetDate()}, at {GetTime()}");
		Console.Write("In ");
		_address.DisplayAddress();
		Console.WriteLine();
	}

	public void ShortDet()
	{
		Console.WriteLine($"Title: {GetTitle()}");
		Console.WriteLine($"Date: {GetDate()}");
	}
}