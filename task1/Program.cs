
int WriteNum(string messege) {
    Console.WriteLine(messege);

    int outNum = Convert.ToInt32(Console.ReadLine());

    return outNum;
}

int SecondNum(int num){
    return num / 10 % 10;
}


void OutResult(int number){
    while (true){
        if (number == 0){
            Console.WriteLine("Exit");
            break;
        }
        else if (number < 100 || number > 1000){
            OutResult(WriteNum("Input num"));
        }
        else{
            Console.WriteLine($"Second number `{SecondNum(number)}`");
        }
        break;
    }
}    

OutResult(WriteNum("Input num"));