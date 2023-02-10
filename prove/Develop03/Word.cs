using System;

public class Word
{
  public string _word;
  public bool _isHidden;

  public Word(string word)
  {
    _word = word;
    _isHidden = false;
  }

  public void HideWord()
  {
    int strLength = _word.Length;
    string result = String.Concat(Enumerable.Repeat("_", strLength));
    _word = result;
    _isHidden = true;
  }
}