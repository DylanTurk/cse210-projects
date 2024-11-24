using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);

        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());

        foreach (var word in _words)
        {
            if (word.IsHidden)
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }

        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        int index = _random.Next(0, _words.Count);
        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}