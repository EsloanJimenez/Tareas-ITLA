int[] num = new int[10];
int change = 0;

for(int i = 0; i < num.Length; i++)
{
    Console.Write($"Digite el valor {i+1}: ");
    num[i] = int.Parse( Console.ReadLine() );
}

for(int x = 0; x < num.Length-1; x++)
{
    for(int y = 0; y < num.Length-1; y++)
    {
        if (num[y] > num[y+1])
        {
            change = num[y];
            num[y] = num[y + 1];
            num[y + 1] = change;
        }
    }
}


for(int y = 0; y < num.Length-1; y++)
{
    Console.WriteLine($"valor de la posicion {y+1}: {num[y]}");
}