// Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)

int[,,] FillMatrix(int row, int col, int lenght, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[row, col, lenght];
    // Random rand = new Random();
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }

    return tempMatrix;
}


void PrintMatrix(int[,,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFotPrint.GetLength(2); k++)
            {
                Console.WriteLine($"matrixFotPrint[{i}][{j}][{k}] = {matrixFotPrint[i, j, k]}");
            }
        }
        // System.Console.WriteLine(" ");
    }
}


int[,,] array = FillMatrix(2,2,2, 10,100);
// Вывод массива построчно с добавлением индексов
PrintMatrix(array);