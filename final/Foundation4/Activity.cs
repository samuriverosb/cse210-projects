using System;

public abstract class Activity
{
	private double _distance;
	private double _speed;
	private double _pace;
	private int _minutes;
	private string _date = DateTime.Today.ToString("D");

	public Activity(int minutes)
	{
		_minutes = minutes;
	}	
	public Activity(double distance, int minutes)
	{
		_minutes = minutes;
		_distance = distance;
	}
	public Activity(int minutes, double speed)
	{
		_speed = speed;
		_minutes = minutes;
	}

	public double GetDistance()
	{
		return _distance;
	}
	public void SetDistance(double distance)
	{
		_distance = distance;
	}
	public double GetSpeed()
	{
		return _speed;
	}
	public void SetSpeed(double speed)
	{
		_speed = speed;
	}
	public double GetPace()
	{
		return _pace;
	}
	public void SetPace(double pace)
	{
		_pace = pace;
	}
	public int GetMinutes()
	{
		return _minutes;
	}
	public string GetDate()
	{
		return _date;
	}

	public abstract void CalculateDistance();
	public abstract void CalculateSpeed();
	public abstract void CalculatePace();
	public virtual void GetSummary()
	{
		Console.WriteLine();
		Console.WriteLine($"{GetDate()} {this.GetType().Name} ({GetMinutes()} min): Distance {GetDistance().ToString("F")} km, Speed {GetSpeed().ToString("F")} kph, Pace {GetPace().ToString("F")} min per km");
		Console.WriteLine();
	}
}