int a=Convert.ToInt32(Console.ReadLine());

int[] m = new int[a];
for (int i = 0; i < a; i++) 
{
    m[i]=Convert.ToInt32(Console.ReadLine());   
}

int k=Convert.ToInt32(Console.ReadLine());  

for (int i = 0; i < a; i++) 
{
    if (i==k) continue ;
    Console.Write(m[i]+" ");
}  