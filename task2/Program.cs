
int WriteNum(string messege) {
    Console.WriteLine(messege);

    int outNum = Convert.ToInt32(Console.ReadLine());

    return outNum;
}

int ThirdNum(int num){
    while (num > 999){
        num /= 10;
    }
    return num % 10;
}


void OutResult(int number){
    while (true){
        if (number == 0){
            Console.WriteLine("Exit");
            break;
        }
        else if (number < 100){
            OutResult(WriteNum("there is no third digit"));
        }
        else{
            Console.WriteLine($"Third digit `{ThirdNum(number)}`");
        }
        break;
    }
}    

OutResult(WriteNum("Input num"));