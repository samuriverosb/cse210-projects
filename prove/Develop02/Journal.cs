using System;

public class Journal
{
	public List<Entry> _listEntries = new List<Entry>();
	public void DisplayJournal()
	{
		foreach (Entry entry in _listEntries)
		{
			Console.WriteLine($"Date: {entry._currentDate} - {entry._promptGenerated}");
			Console.WriteLine($"{entry._input}");
			Console.WriteLine();
		}
	}
	public void SaveEntry(Entry entry)
	{
		_listEntries.Add(entry);
	}
}