using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0) break;
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void ShowHint()
    {
        var hiddenWords = _words.Where(word => word.IsHidden()).ToList();
        if (hiddenWords.Count > 0)
        {
            hiddenWords.First().ShowFirstLetter();
        }
    }
}