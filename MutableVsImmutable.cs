using System.Text;

namespace ArraysStrings;

public class MutableVsImmutable
{
    static void Main(string[] args)
    {
        MutableVsImmutable obj = new();
        obj.CheckString();
        obj.CheckString2();
    }

    public void CheckString()
    {
        string firstName = "My ";
        firstName += "Name ";
        firstName += "Is ";
        firstName += "Shilpa";

        Console.WriteLine(firstName);
    }

    public void CheckString2()
    {
        StringBuilder builder = new();
        builder.Append("My");
        builder.Append(" Name");
        builder.Append(" Is");
        builder.Append(" Shilpa");

        Console.WriteLine(builder.ToString());
    }
}