using System;

public class Cycling : Activity
{
	public Cycling(int minutes, double speed) : base(minutes, speed)
	{
	}

	public override void CalculateDistance()
	{
		base.SetDistance((base.GetSpeed()/60) * base.GetMinutes());
	}
	public override void CalculateSpeed()
	{
	}
	public override void CalculatePace()
	{
		base.SetPace(base.GetMinutes()/base.GetDistance());
	}
}