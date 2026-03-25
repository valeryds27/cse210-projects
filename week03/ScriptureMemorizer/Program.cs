using System;
// I added a prompt to ask the user for a difficulty level: Easy, Medium, or Hard.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose difficulty level: Easy, Medium, Hard");
        string difficultyInput = Console.ReadLine().ToLower();

        int wordsToHide;

        switch (difficultyInput)
        {
            case "easy":
                wordsToHide = 1;
                break;
            case "medium":
                wordsToHide = 3;
                break;
            case "hard":
                wordsToHide = 5;
                break;
            default:
                wordsToHide = 3; 
                break;
        }

       Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}