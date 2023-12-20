using System;

class davaleba4_2_2
{
    static void Main()
    {
        int[] firstArray = { 1, 2, 3 };

        int[] secondArray = { 4, 5, 6 };

        int[] thirdArray = new int[firstArray.Length + secondArray.Length];

        for (int i = 0; i < firstArray.Length; i++)
        {
            thirdArray[i] = firstArray[i];
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            thirdArray[secondArray.Length + i] = secondArray[i];
        }

        Console.WriteLine("Third Array:");
        foreach (var item in thirdArray)
        {
            Console.Write($"{item} ");
        }
    }

   
}
