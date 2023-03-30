using System;

public class Swimming : Activity
{
	private int _laps;

	public Swimming(int minutes, int laps) : base(minutes)
	{
		_laps = laps;
	}

	public override void CalculateDistance()
	{
		base.SetDistance(((_laps * 50) / 1000));
	}
	public override void CalculateSpeed()
	{
		base.SetSpeed((base.GetDistance()/base.GetMinutes()) * 60);
	}
	public override void CalculatePace()
	{
		base.SetPace(base.GetMinutes()/base.GetDistance());
	}
}