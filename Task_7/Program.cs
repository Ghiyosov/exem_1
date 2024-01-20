int sum = 0;
void SumOfDigits(int a) 
{

    if (a == 0) Console.WriteLine(sum);

    else
    {
        sum = sum + a % 10;
        SumOfDigits(a / 10);
    }
}

SumOfDigits(12345);