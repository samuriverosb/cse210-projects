using System.IO;

public class Files
{
	public void SaveFile(string filename, Journal journal)
	{
		using (StreamWriter outputFile = new StreamWriter(filename))
		{
			foreach (Entry entry in journal._listEntries)
			{
				outputFile.WriteLine($"{entry._currentDate},{entry._promptGenerated},{entry._input}");
			}
		}
	}
	public void LoadFile(string filename, Journal journal)
	{
		string[] lines = System.IO.File.ReadAllLines(filename);
		foreach (string line in lines)
		{
			string[] parts = line.Split(",");
			Entry entry = new Entry();
			entry._currentDate = parts[0];
			entry._promptGenerated = parts[1];
			entry._input = parts[2];
			journal.SaveEntry(entry);
		}
	}
}