namespace ArraysStrings;

public class MultiDimesionalArray
{
    
    
    // static void Main(string[] args)
    // {
    //     MultiDimesionalArray objNew = new();
    //     objNew.MultiDimensional();
    // }

    public void MultiDimensional()
    {
        string[] userNames = new string[4] { "A", "B", "C", "D"};

        int[,] twoDArray = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 34, 23, 45, 26 },
            { 23, 23, 45, 56 }
        };

        for (int i = 0; i < twoDArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDArray.GetLength(1); j++)
            {
                Console.WriteLine(twoDArray[i,j]);
            }
        }
    }
}