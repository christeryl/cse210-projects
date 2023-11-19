using System;

public class Scripture
{
    private Word[] _words;
    private Reference _reference;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        InitializeWords(text);
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        _words = new Word[wordArray.Length];

        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.GetDisplayText()}\n");
        foreach (Word word in _words)
        {
            if (word.IsHidden)
                Console.Write("_ ");
            else
                Console.Write($"{word.Value} ");
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        foreach (Word word in _words)
        {
            if (!word.IsHidden && random.Next(2) == 0)
            {
                word.IsHidden = true;
            }
        }
    }

    public bool AllWordsHidden() //true or false
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
}
