int Prompt(string mssg){
    Console.WriteLine(mssg);
    int numm = Convert.ToInt32(Console.ReadLine());
    return numm;
}


int CheckNum(int numm){
    if (numm > 0){
        return numm;
    }
    return -1;
}


int numm = Prompt("Input num");
while (true){
    if  (numm > 0){
        Console.WriteLine($"{numm} > 0");
        numm = CheckNum(Prompt("Input num"));
    }
    else
    {
        break;
    }
}