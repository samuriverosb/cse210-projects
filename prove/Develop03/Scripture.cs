using System;

public class Scripture
{
  private string _reference;
  private List<Word> _scripture = new List<Word>();
  public bool _isCompletelyHidden = false;

  public Scripture(string reference, string scripture)
  {
    string[] words = scripture.Split(' ');
    foreach (string word in words)
    {
      Word x = new Word(word);
      _scripture.Add(x);
    }
    _reference = reference;
  }

  public void HideWords()
  {
    Random random = new Random();
    int wordsHidden = 0;
    
    while (wordsHidden <= 2 || _isCompletelyHidden)
    {
      CheckIfHidden();
      if (_isCompletelyHidden)
      {
        DisplayScripture();
        break;
      }
      int randomIndex = random.Next(0, _scripture.Count);
      if (!_scripture[randomIndex]._isHidden)
      {
        _scripture[randomIndex].HideWord();
        wordsHidden += 1;
      }
    }
  }

  public void DisplayScripture()
  {
    List<string> listOfWords = new List<string>();
    foreach(Word word in _scripture)
    {
      listOfWords.Add(word._word);
    }
    string scripture = string.Join(" ", listOfWords);
    Console.Clear();
    Console.WriteLine($"{_reference} {scripture}");
  }

  private void CheckIfHidden()
  {
    int notHidden = 0;
    foreach (Word word in _scripture)
    {
      if (!word._isHidden)
      {
        notHidden += 1;
      }
    }
    if (notHidden == 0)
    {
      _isCompletelyHidden = true;
    }
  }
}