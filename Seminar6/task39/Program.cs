// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void ReverseArray(int[] arrayToReverse)
{
    int temp;
    for(int i = 0; i < arrayToReverse.Length/2; i++)
    {
        temp = arrayToReverse[i];
        arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - 1 - i];
        arrayToReverse[arrayToReverse.Length - 1 - i] = temp;
    }
}

// ------------------------------------------

int[] array = FillArray(10, -9, 9);
PrintArray(array);

ReverseArray(array);
PrintArray(array);

Array.Reverse(array);
PrintArray(array);