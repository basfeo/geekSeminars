// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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


int[] QuantityNum(int[,] matrix){
    int[] dict = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            dict[matrix[i,j]]++;
        }
    }
    return dict;
}


void PrintDictionary(int[]array){
for (int i = 0; i < array.Length; i++)
{
 if (array[i]!=0){
    System.Console.WriteLine($"Число {i} встречается {array[i]} раз");
 }   
}
}
//..

int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[,] matrix = FillMatrix(size[0], size[1], 0, 9);

PrintMatrix(matrix);
System.Console.WriteLine("");
PrintDictionary(QuantityNum(matrix));