
namespace ArraysStrings;

public class ArrayClassDemo
{
    // static void Main(string[] args)
    // {
    //     ArrayClassDemo arrayDemo = new();
    //     arrayDemo.OneDimensionalArray();
    // }

    public void OneDimensionalArray()
    {
        string[] userNames = new string [5] { "Ram", "Shyam", "Mohan", "Abhimanyu","Rahul" };

        foreach (string unsortedArray in userNames)
        {
            Console.WriteLine(unsortedArray);
        }

        Console.WriteLine("----------------------------------------------------");
        
        Array.Sort(userNames);
        
        foreach (string sortedArray in userNames)
        {
            Console.WriteLine(sortedArray);
        }
    }
}




// public class SubjectTakenByStudent
// {
//     public string StudentName { get; set; } = default!;
//
//     public List<string> SubjectTaken { get; set; } = default!;
// }