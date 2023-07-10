int SumNaturalNumbers(int m, int n)
{
    if (m > n)
        return 0;
    else
        return m + SumNaturalNumbers(m + 1, n);
}

void InOutResult(string text)
{
    Console.Write("Введите значение M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите значение N: ");
    int n = int.Parse(Console.ReadLine());

    int sum = SumNaturalNumbers(m, n);
    Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");
    Console.ReadLine();
}

InOutResult("Imput num");