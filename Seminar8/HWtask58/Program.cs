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


// Проверка возможности умножения матриц


int[,] NewMatrix(int[,] matrix1, int[,] matrix2){
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    // Создание результирующей матрицы
    int[,] resultMatrix = new int[rows1, cols2];

    if (cols1 != rows2)
    {
        Console.WriteLine("Умножение матриц невозможно!");
        return resultMatrix;
    }
    
    // Вычисление произведения матриц
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}


// Исходные матрицы
int row1 = ReadInt("Задайте количество строк и столбцов через запятую: ");
int col1 = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[,] matrix1 = FillMatrix(row1, col1, 0, 9);
Console.WriteLine("Это первая матрица!");
PrintMatrix(matrix1);
Console.WriteLine("\n");


int row2 = ReadInt("Задайте количество строк и столбцов через запятую: ");
int col2 = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[,] matrix2 = FillMatrix(row2, col2, 0, 9);
Console.WriteLine("Это вторая матрица!");
PrintMatrix(matrix2);
Console.WriteLine("\n");

int[,] resultMatrix = NewMatrix(matrix1, matrix2);
Console.WriteLine("Это результат перемножения!");
PrintMatrix(resultMatrix);