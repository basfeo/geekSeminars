void GetBinary(int num){
    if (num > 1){
        GetBinary(num/2);
    }
    Console.Write(num%2);
}

GetBinary(13);
