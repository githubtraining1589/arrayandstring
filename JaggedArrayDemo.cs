namespace ArraysStrings;

public class JaggedArrayDemo
{
    // static void Main(string[] args)
    // {
    //     JaggedArrayDemo obj = new();
    //     obj.JaggedArray();
    // }

    public void JaggedArray()
    {
        int[][] jaggedArrayobj = new int[4][];

        jaggedArrayobj[0] = new int[] { 1, 67, 34 };
        jaggedArrayobj[1] = new int[] { 1, 67, 34, 54, 23, 56, 23 };
        jaggedArrayobj[2] = new int[] { 1, 67};
        jaggedArrayobj[3] = new int[] { 1, 67, 89 };

        for (int i = 0; i < jaggedArrayobj.Length; i++)
        {
            for (int j = 0; j < jaggedArrayobj[i].Length; j++)
            {
                Console.WriteLine(jaggedArrayobj[i][j]);
            }
        }



    }
    
    
}