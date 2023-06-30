// // See https://aka.ms/new-console-template for more information

// int[] array = new int[12];
// int sumPositive = 0;
// int sumNegative = 0;
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }

// System.Console.WriteLine("[" + string.Join(", ", array) + "]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive += array[i]; // sumPositive = sumPositive + array[i]
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }

// System.Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");
// System.Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");

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

void FindSumPositiveAndNegative(int[] tempArray, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] > 0)
        {
            sumP += tempArray[i]; // sumPositive = sumPositive + array[i]
        }
        else
        {
            sumN += tempArray[i];
        }
    }
}
// ---------------------------------------------------------------------------

int[] array = FillArray(12, -9, 9);
PrintArray(array);
FindSumPositiveAndNegative(array, out int sumPositive, out int sumNegative);

System.Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");