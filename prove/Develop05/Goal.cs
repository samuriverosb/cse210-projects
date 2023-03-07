using System;

public class Goal
{
	private string _name;
	private string _description;
	private int _points;

	// Getters & Setters
	public string GetName()
	{
		return _name;
	}
	public string GetDescription()
	{
		return _description;
	}
	public int GetPoints()
	{
		return _points;
	}

	public void SetName(string name)
	{
		_name = name;
	}
	public void SetDescription(string description)
	{
		_description = description;
	}
	public void SetPoints(int points)
	{
		_points = points;
	}

	public Goal(string name, string description, int points)
	{
		_name = name;
		_description = description;
		_points = points;
	}

	public virtual string GetGoal()
	{
		return $"[ ] {_name} ({_description})";
	}

		public virtual int GetCompletedTimes()
	{
		return 0;
	}
	public virtual void SetCompletedTimes(int n, string load)
	{
	}

	public virtual int GetTimes()
	{
		return 0;
	}
	public virtual void SetTimes(int times)
	{
	}
		public virtual bool GetCompleted()
	{
		return false;
	}
	public virtual void SetCompleted(bool completed)
	{
	}
	public virtual int GetBonus()
	{
		return 0;
	}
	public virtual string GetFormattedText()
	{
		return "";
	}
}