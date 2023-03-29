using System;

public class Comments
{
	private string _name;
	private string _comment;

	public Comments(string name, string comment)
	{
		_name = name;
		_comment = comment;
	}

	public void SetName(string name)
	{
		_name = name;
	}
	public string GetName()
	{
		return _name;
	}
	public void SetComment(string comment)
	{
		_comment = comment;
	}
	public string GetComment()
	{
		return _comment;
	}

	public void DisplayComment()
	{
		Console.WriteLine($"{_name}: {_comment}");
	}
}