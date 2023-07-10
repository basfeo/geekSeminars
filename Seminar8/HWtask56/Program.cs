// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    // Random rand = new Random();
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixFotPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int[] RowSum(int[,] array,int row){
    int[] RowSum = new int[row];
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            RowSum[i] += array[i,j];
        }
    }
    return RowSum;
}

void ShowMin(int[] array){
    int min = 0;
    int result = array[0];
    for (int i = 1;i < array.Length; i++){
        if (result > array[i]){
            result = array[i];
            min = i;
        }
        
    }
    Console.WriteLine($"Index row: {min}");
}


void PrintArray(int[] array){
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int row = ReadInt("Задайте количество строк и столбцов через запятую: ");
int col = ReadInt("Задайте количество строк и столбцов через запятую: ");

int[,] array = FillMatrix(row,col,  0, 9);
Console.WriteLine("Исходный массив:");
PrintMatrix(array);

int[] RowSum1 = RowSum(array,row);
ShowMin(RowSum1);