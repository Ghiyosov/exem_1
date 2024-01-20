int a=Convert.ToInt32(Console.ReadLine());

int[] m = new int[a];
for (int i = 0; i < a; i++) 
{
    m[i]=Convert.ToInt32(Console.ReadLine());   
}

int z = 1;

for (int i = 1; i < a; i++) 
{
    if (m[i-1] != m[i]) z++;
}
Console.WriteLine(z);   