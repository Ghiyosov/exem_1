int a=Convert.ToInt32(Console.ReadLine());

int[] m = new int[a];
for (int i = 0; i < a; i++) 
{
    m[i]=Convert.ToInt32(Console.ReadLine());   
}

int k = 1234567, z=-123467;

for (int i = 0; i < a; i++) 
{
    if (m[i] >= 0) m[i] = 0;

}
for (int i = 0; i < a; i++) 
{
    Console.Write(m[i]+" ");
}


   