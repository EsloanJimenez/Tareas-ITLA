Console.Write("Digite el valor que quiere saber si es primo: ");
int num = int.Parse(Console.ReadLine());

bool EsPrimo (int num)
{
    if(num <= 1) return false;

    for(int i = 2; i < num; i++)
    {
        if(num % i == 0) return false;
    }

    return true;
}

if (EsPrimo(num)) Console.WriteLine($"El numero {num} es primo");
else Console.WriteLine($"El numero {num} no es primo.");

Console.ReadKey();