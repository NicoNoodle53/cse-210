using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        scripture.MakeList();

        while (response != "quit")
        {
            Console.WriteLine($"{reference.displayReference()} {scripture.ShowPhrase()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            Console.Clear();
            if(scripture.CheckIfBlank() == true)
            {
                break;
            }
            scripture.Make3WordsBlank();
        }



    }
}