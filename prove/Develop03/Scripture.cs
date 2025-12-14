using System;

public class Scripture
{
    private string _scripture = "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.";
    private List<Word> _words = new List<Word>();

    public void MakeList()
    {
        string[] wordsArray = _scripture.Split(new char[]{' '});
        
        foreach (string wordText in wordsArray)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }
    public string ShowPhrase()
    {
        string phrase = "";
        foreach (Word wordObject in _words)
        {
            phrase += wordObject._word;
            phrase += " ";
        }
        return phrase;
    }
    public void Make3WordsBlank()
    {
        for (int i = 0; i < 3; i ++)
        {
            Random randomGenerator = new Random();
            int randomNumb = randomGenerator.Next(0, _words.Count);
            _words[randomNumb].MakeBlank();
        }
    }
    public bool CheckIfBlank()
    {
        int hiddenFalse = 0;
        foreach (Word wordObject in _words)
        {
            if (wordObject._Hidden == false)
            {
                hiddenFalse ++;
            }
        }
        if (hiddenFalse == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}