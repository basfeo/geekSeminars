// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int ConvertNum(string messege){
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}


bool CheckWeekenDay(int day){
    if (day > 5){
        return true;
    }
    return false;
}


bool Validate(int num){
    if (num > 0 && num <= 7){
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}


int weekDay = ConvertNum("Input num");
if(Validate(weekDay)){
    if (CheckWeekenDay(weekDay)){
        Console.WriteLine("Weekend");
    }
    else
    {
        Console.WriteLine("Weekday");
    }
}