double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return tempArray;
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
	
}


double DiffNum(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++){
        if (min > array[i]){
            min = array[i];
        }
    }
    for (int i = 1; i < array.Length; i++){
        if (max < array[i]){
            max = array[i];
        }
    }
    return max - min;
}

double[] arr = FillArray(5,1,5);
PrintArray(arr);
Console.Write(DiffNum(arr));