using System;

public class Running : Activity
{
	public Running(int minutes, double distance) : base(distance, minutes)
	{
	}

  	public override void CalculateDistance()
  	{
		
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