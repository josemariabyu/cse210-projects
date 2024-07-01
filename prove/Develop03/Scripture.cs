using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4); // Hide between 1 and 3 words at a time

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());
            if (visibleWords.Count == 0) return;

            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}
