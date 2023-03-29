using System;

public class Reception : Event
{
	private string _email;

	public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
	{
		_email = email;
	}

	public string GetEmail()
	{
		return _email;
	}

	public void FullDetails()
	{
		base.StandardDetails();
		Console.WriteLine($"RSVP will be emailed to: {GetEmail()}");
        Console.WriteLine();
	}
	public void ShortDetails()
	{
		Console.WriteLine($"{this.GetType().Name} Event");
		base.ShortDet();
        Console.WriteLine();
	}
}