Console.Write("Ingrese el primer valor: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo valor: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tercer valor: ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminante = b * b - 4 * a * c;

if (discriminante > 0)
{
    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

    Console.WriteLine($"Las soluciones son x1 = {x1} y x2 = {x2}");
}
else if (discriminante == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"La solución es x = {x}");
}
else
{
    double real = -b / (2 * a);
    double imaginario = Math.Sqrt(-discriminante) / (2 * a);

    Console.WriteLine($"Las soluciones son complejas:");
    Console.WriteLine($"x1 = {real} + {imaginario}i");
    Console.WriteLine($"x2 = {real} - {imaginario}i");
}

Console.ReadLine();