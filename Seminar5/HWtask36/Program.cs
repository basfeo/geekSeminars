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


void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
//+|+|+|+|+|+|+|+|+|+|+|+|  

void SummOddPositions(int[] tempArray)
{
    int summ = 0;
    for (int index = 1; index < tempArray.Length; index++)
    {
        summ += tempArray[index];
        index +=1;
    }
    System.Console.WriteLine(summ);
}

int [] array = FillArray(11, -15, 15);
PrintArray(array);
SummOddPositions(array);