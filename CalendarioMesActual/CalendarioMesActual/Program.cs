DateTime fecha = DateTime.Now;

int diaDelMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);

DateTime primerDiaDelMes = new DateTime(fecha.Year, fecha.Month, 1);

int inicio = ((int)primerDiaDelMes.DayOfWeek + 6) % 7;

Console.WriteLine("lu ma mi ju vi sa do");


for (int i = 0; i < inicio; i++)
{
    Console.Write("   ");
}

for (int j = 1; j <= diaDelMes; j++)
{
    Console.Write($"{j,2} ");
    if ((inicio + j) % 7 == 0)
        Console.WriteLine();
}
Console.WriteLine();