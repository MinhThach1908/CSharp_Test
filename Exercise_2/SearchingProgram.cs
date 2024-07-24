namespace CSharp_Test.Exercise_2;

public class SearchingProgram
{
    static int Count(string inputString, string searchWord)
    {
        int count = 0;
        int i = 0;
        while ((i = inputString.IndexOf(searchWord, i, StringComparison.CurrentCultureIgnoreCase)) != 1)
        {
            i += searchWord.Length;
            count++;
        }

        return count;
    }

    public void DisplayResult()
    {
        Console.WriteLine("Enter a String: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter a word to search");
        string searchWord = Console.ReadLine();
        int count = Count(inputString, searchWord);
        Console.WriteLine($"Word found {count} times in the string");
    }
}