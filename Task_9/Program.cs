
int z = 0;

void IncrementArrayElements(ref int[] arr, ref int n) 
{
    if (z == arr.Length)
        return;
    arr[z] = arr[z] + n;
    z++;
    IncrementArrayElements(ref arr, ref n);
}

int[] arr =  new int[5] {1,2,3,4,5};
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr.Length; i++) 
{
    Console.Write(arr[i]+" ");

}
Console.WriteLine();
IncrementArrayElements(ref arr, ref n);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");

}