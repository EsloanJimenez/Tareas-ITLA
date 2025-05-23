Console.Write("Digite su fecha de nacimiento: ");
DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine($"El dia de la semana de su nacimiento es: {fechaNacimiento.DayOfWeek}");

Console.ReadLine();