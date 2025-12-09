using System.Runtime.InteropServices;

public class Reference
{
    private string _book = "Jhon";
    private int _chapter = 14;
    private int _startVerse = 27;
    private int _endVerse = 27;

    public string displayReference()
    {
        string reference;
        if(_startVerse != _endVerse)
        {
            reference = ($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
        else
        {
            reference = ($"{_book} {_chapter}:{_startVerse} ");
        }
        return reference;
    }
}