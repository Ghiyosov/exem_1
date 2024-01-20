void Swap(ref int a, ref int b) 
{
    int z;
    z = a;
    a = b; 
    b = z;   
}

int x, y;
x=Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}  y = {y}");
Swap(ref x, ref y);
Console.WriteLine($"x = {x}  y = {y}");
