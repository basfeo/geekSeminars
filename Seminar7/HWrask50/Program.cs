// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            // tempMatrix[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
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


void SeachNum(int[,] matrix, int ind_row, int ind_col){
    if (ind_row <= matrix.GetLength(0)){
        if (ind_col <= matrix.GetLength(1)){
            System.Console.WriteLine(matrix[ind_row, ind_col]);
        }
    }
    else
    {
        System.Console.WriteLine("Not found");
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);

SeachNum(matrix, ReadInt("Input row ind: "), ReadInt("Input col ind: "));