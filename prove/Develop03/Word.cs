using System;

public class Word
{
    public string _word;
    public Boolean _Hidden;
    private int _leangth;

    public Word(string text)
    {
        _word = text;
        _leangth = text.Length;
        _Hidden = false;
    }

    public void MakeBlank()
    {
        _Hidden = true;
        _word = "";
        for (int i = 0; i < _leangth; i++)
        {
            _word += "_";
        }
    }

}