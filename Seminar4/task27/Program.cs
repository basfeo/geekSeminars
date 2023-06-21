// See https://aka.ms/new-console-template for more information
int SumDigitInNum(int number){
    int result = 0,rev = 0;
    while (number > 0){
        rev = number % 10;
        result += rev;
        number /= 10;
    }
    return result;
}


int TransformationInNum(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(SumDigitInNum(TransformationInNum("Input number")));