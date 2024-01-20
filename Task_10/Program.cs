


void Elements(int a, int b) 
{
    if (a % 2 == 0) Console.Write(a + " ");
    if (a == b)
        return;
    
    a++;

    Elements(a, b);
}

Elements(5, 20);

Console.WriteLine();


void Elements1(int a, int b)
{
    if (a % 2 != 0) Console.Write(a + " ");


    if (a == b)
        return;
    a++;

    Elements1(a, b);
}

Elements1(5, 20);