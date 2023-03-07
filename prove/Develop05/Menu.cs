using System;
using System.IO;

public class Menu
{
	private string _choice;
	private string _goalChoice;
	private int _totalPoints = 0;
	private List<Goal> _list = new List<Goal>();

	public List<Goal> GetList()
	{
		return _list;
	}
	public void AppInit()
	{
		while (_choice != "6")
		{
			Console.WriteLine();
			Console.WriteLine($"You have {_totalPoints} points.");
			Console.WriteLine();
			Console.WriteLine("Menu Options:");
			Console.WriteLine("  1. Create New Goal");
			Console.WriteLine("  2. List Goals");
			Console.WriteLine("  3. Save Goals");
			Console.WriteLine("  4. Load Goals");
			Console.WriteLine("  5. Record Event");
			Console.WriteLine("  6. Quit");
			Console.Write("Select a choice from the menu: ");
			_choice = Console.ReadLine();
			if (_choice == "1")
			{
				SelectGoal();
			}
			else if (_choice == "2")
			{
				ListGoals();
			}
			else if (_choice == "3")
			{
				SaveGoals();
			}
			else if (_choice == "4")
			{
				LoadGoals();
			}
			else if (_choice == "5")
			{
				RecordEvent();
			}
			else
			{
				continue;
			}
		}
		
	}

	private void SelectGoal()
	{
		Console.WriteLine("The types of goals are:");
		Console.WriteLine("  1. Simple Goal");
		Console.WriteLine("  2. Eternal Goal");
		Console.WriteLine("  3. Checklist Goal");
		Console.Write("Which type of goal would you like to create? ");
		_goalChoice = Console.ReadLine();
		if (_goalChoice == "1")
		{
			SimpleGoalCreator();
		}
		else if (_goalChoice == "2")
		{
			EternalGoalCreator();
		}
		else if (_goalChoice == "3")
		{
			ChecklistGoalCreator();
		}
	}

	private void SimpleGoalCreator()
	{
		string name;
		string description;
		int points;

		Console.Write("What is the name of your Goal? ");
		name = Console.ReadLine();
		Console.Write("What is a short description of it? ");
		description = Console.ReadLine();
		Console.Write("What is the amount of points associated with this goal? ");
		points = Int32.Parse(Console.ReadLine());
		SimpleGoal simple = new SimpleGoal(name, description, points);
		_list.Add(simple);
	}

	private void EternalGoalCreator()
	{
		string name;
		string description;
		int points;

		Console.Write("What is the name of your Goal? ");
		name = Console.ReadLine();
		Console.Write("What is a short description of it? ");
		description = Console.ReadLine();
		Console.Write("What is the amount of points associated with this goal? ");
		points = Int32.Parse(Console.ReadLine());
		EternalGoal eternal = new EternalGoal(name, description, points);
		_list.Add(eternal);
	}

	private void ChecklistGoalCreator()
	{
		string name;
		string description;
		int points;
		int times;
		int bonus;

		Console.Write("What is the name of your Goal? ");
		name = Console.ReadLine();
		Console.Write("What is a short description of it? ");
		description = Console.ReadLine();
		Console.Write("What is the amount of points associated with this goal? ");
		points = Int32.Parse(Console.ReadLine());
		Console.Write("How many times does this goal need to be accomplished for a bonus? ");
		times = Int32.Parse(Console.ReadLine());
		Console.Write("What is the bonus for accomplishing it that many times? ");
		bonus = Int32.Parse(Console.ReadLine());
		ChecklistGoal check = new ChecklistGoal(name, description, points, times, bonus);
		_list.Add(check);
	}

	private void ListGoals()
	{ int counter = 1;
	Console.WriteLine();
		foreach(Goal goal in _list)
		{
			Console.WriteLine($"{counter}. {goal.GetGoal()}");
			counter += 1;
		}
	}

	private void RecordEvent()
	{
		Console.WriteLine();
		Console.WriteLine("The goals are: ");
		int counter = 1;
		foreach(Goal goal in _list)
		{
			Console.WriteLine($"  {counter}. {goal.GetName()}");
			counter += 1;
		}
		Console.Write("Which goal did you accomplish? ");
		int index = Int32.Parse(Console.ReadLine()) - 1;
		if (_list[index].GetType().Name == "SimpleGoal")
		{
			_list[index].SetCompleted(true);
			_totalPoints += _list[index].GetPoints();
			Console.WriteLine($"Congrats! You got {_list[index].GetPoints()} Points!!");
		}
		else if (_list[index].GetType().Name == "EternalGoal")
		{
			_totalPoints += _list[index].GetPoints();
			Console.WriteLine($"Congrats! You got {_list[index].GetPoints()} Points!!");
		}
		else if (_list[index].GetType().Name == "ChecklistGoal")
		{
			_list[index].SetCompletedTimes(0, "noload");
			if (_list[index].GetCompletedTimes() / _list[index].GetTimes() == 1)
			{
				Console.WriteLine($"Congrats! You completed {_list[index].GetTimes()}/{_list[index].GetTimes()}! You got {_list[index].GetBonus()} Points!!");
				_totalPoints += _list[index].GetBonus();
			}
			else
			{
				Console.WriteLine($"Congrats! You completed {_list[index].GetCompletedTimes()}/{_list[index].GetTimes()}! You got {_list[index].GetPoints()} Points!!");
				_totalPoints += _list[index].GetPoints();
			}
		}
	}

	private void SaveGoals()
	{
		Console.WriteLine();
		Console.Write("What is the filename for the Goal file? (Please add .txt extension): ");
		string filename = Console.ReadLine();

		using (StreamWriter outputFile = new StreamWriter(filename))
		{
			outputFile.WriteLine($"{_totalPoints}");
			foreach (Goal goal in _list)
			{
				outputFile.WriteLine(goal.GetFormattedText());
			}
		}
	}

	private void LoadGoals()
	{
		Console.WriteLine();
		Console.Write("What is the filename for the Goal file you want to load? (Please add .txt extension): ");
		string filename = Console.ReadLine();
		string[] lines = System.IO.File.ReadAllLines(filename);
		_totalPoints = Int32.Parse(lines[0]);
		foreach (string line in lines.Skip(1))
		{
			string[] parts = line.Split(":");
			string[] content = parts[1].Split(",");
			if (parts[0] == "SimpleGoal")
			{
				SimpleGoal simple = new SimpleGoal(content[0], content[1], Int32.Parse(content[2]), bool.Parse(content[3]));
				_list.Add(simple);
			}
			else if (parts[0] == "EternalGoal")
			{
				EternalGoal eternal = new EternalGoal(content[0], content[1], Int32.Parse(content[2]));
				_list.Add(eternal);
			}
			else if (parts[0] == "ChecklistGoal")
			{
				ChecklistGoal check = new ChecklistGoal(content[0], content[1], Int32.Parse(content[2]), Int32.Parse(content[3]), Int32.Parse(content[4]), Int32.Parse(content[5]));
				_list.Add(check);
			}
		}
	}
}