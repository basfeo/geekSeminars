int[,] array = new int[4, 4];
int value = 1;  // начальное значение для заполнения
int rowCount = array.GetLength(0);
int colCount = array.GetLength(1);
int minRow = 0;
int maxRow = rowCount - 1;
int minCol = 0;
int maxCol = colCount - 1;
while (value <= rowCount * colCount)
{
    // вправо
    for (int i = minCol; i <= maxCol; i++)
    {
        array[minRow, i] = value++;
    }
    minRow++;
    // вниз
    for (int i = minRow; i <= maxRow; i++)
    {
        array[i, maxCol] = value++;
    }
    maxCol--;

    // влево
    for (int i = maxCol; i >= minCol; i--)
    {
        array[maxRow, i] = value++;
    }
    maxRow--;

    // вверх
    for (int i = maxRow; i >= minRow; i--)
    {
        array[i, minCol] = value++;
    }
    minCol++;
}
// Вывод массива
for (int row = 0; row < rowCount; row++)
{
    for (int col = 0; col < colCount; col++)
    {
        Console.Write(array[row, col] + "\t");
    }
    Console.WriteLine();
}