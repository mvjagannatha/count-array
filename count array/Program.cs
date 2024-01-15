using System;
class arrays
{
    static void Main(string[] args)
    {
        int[] n = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int count = 0;
        foreach(int x in n)
        {
            count++;
        }
        Console.WriteLine(count);
    }
    
}