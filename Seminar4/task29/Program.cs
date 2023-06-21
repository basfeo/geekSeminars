// See https://aka.ms/new-console-template for more information

int[] GetArray(string text){
    Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
    if (array.Length > 8){
        Console.WriteLine("Out of Range. Not more than 8 numbers.");
        GetArray("Input again");
    }
    return array;
}

void PrintArray(int[] array){
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

PrintArray(GetArray("Input array"));