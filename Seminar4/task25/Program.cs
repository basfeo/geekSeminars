// See https://aka.ms/new-console-template for more information
int TransformationInNum(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int num, int exp){
    int result = 1;
    for (int i = 1; i <= exp; i++){
        result *=num;
    }
    return result;
}


Console.WriteLine(Exponentiation(TransformationInNum("Input first"), TransformationInNum("Input second")));