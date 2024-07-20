namespace ArraysStrings;

public class StringDemo
{
    // static void Main(string[] args)
    // {
    //     StringDemo demoObj = new();
    //     demoObj.ContainsExample();
    // }

    public void StringFunctionality()
    {
        string programmingLang = "Javascript";

        string output = programmingLang.Substring(0, 3);

        Console.WriteLine($"Substring : {output}");
        
        string nextInput = "I am learning C#";
        string[] splittedRecords = nextInput.Split(' ');
        foreach (var data in splittedRecords)
        {
            Console.WriteLine(data);
        }

        Console.WriteLine($"Upper Case : {programmingLang.ToUpper()}");
        Console.WriteLine($"Lower Case : {programmingLang.ToLower()}");
        Console.WriteLine($"Total Length : {programmingLang.Length}");
        
        
        
        
    }

    public void ContainsExample()
    {
        string description = "I am learning C#";
        string textToFind = "Learning";

        if (description.Contains(textToFind,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Text Contains: {textToFind}");
        }
        else
        {
            Console.WriteLine($"Text Doesn't Contains: {textToFind}");
        }
    }
}