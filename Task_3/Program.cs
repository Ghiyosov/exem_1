int a=Convert.ToInt32(Console.ReadLine());

int[] m = new int[a];
for (int i = 0; i < a; i++) 
{
    m[i]=Convert.ToInt32(Console.ReadLine());   
}

int k = 1234567, z=-123467;

for (int i = 0; i < a; i++) 
{
    if (m[i] < k) k = i;
    if (m[i] > z) z = i;

}

if (k < z) 
{
    for (int i = k; i <= z; i++)
    {
        Console.Write(m[i] + " ");
    }
}
if (k > z) 
{
    for (int i = z; i <= k; i++)
    {
        Console.Write(m[i] + " ");
    }
}

   