using System;
using System.Collections.Generic;

public class Video
{
	private string _title;
	private string _author;
	private int _length;
	private List<Comments> _comments = new List<Comments>();

	public Video(string title, string author, int length)
	{
		_title = title;
		_author = author;
		_length = length;
	}

	public void SetTitle(string title)
	{
		_title = title;
	}
	public string GetTitle()
	{
		return _title;
	}
	public void SetAuthor(string author)
	{
		_author = author;
	}
	public string GetAuthor()
	{
		return _author;
	}
	public void SetLength(int length)
	{
		_length = length;
	}
	public int GetLength()
	{
		return _length;
	}
	public void SetComments(Comments comment)
	{
		_comments.Add(comment);
	}
	public List<Comments> GetComments()
	{
		return _comments;
	}

	public int GetCount()
	{
		int commentCount = _comments.Count;
		return commentCount;
	}
	public void DisplayComments()
	{
		foreach(Comments comment in _comments)
		{
			comment.DisplayComment();
		}
	}

	public void DisplayVideo()
	{
		Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}s");
		Console.WriteLine($"{GetCount()} Comments");
		Console.WriteLine();
		DisplayComments();
		Console.WriteLine();
		Console.WriteLine();
	}
}