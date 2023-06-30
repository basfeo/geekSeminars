int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}


// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }



void FindEven(int[] tempArray)
{
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] % 2 == 0)
        {
            Console.Write(tempArray[i] + " ");
        }
    }
}

int[] array = FillArray(5, 100, 1000);
// PrintArray(array);

FindEven(array);