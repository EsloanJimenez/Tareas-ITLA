using Calculadora;

int salir = 0;
int op = 0;

do
{
    Console.WriteLine("Que operacion deseas realizar:\n" +
        "1- Suma\n" +
        "2- Resta\n" +
        "3- Multiplicar\n" +
        "4- Dividir\n" +
        "5- Potenciacion\n" + 
        "6- Salir\n");
    op = Convert.ToInt16(Console.ReadLine());

    switch (op)
    {
        case 1: Console.WriteLine(Calcular.Suma());
                salir = Repetir.salir();
        break;

        case 2: Console.WriteLine(Calcular.Resta());
            salir = Repetir.salir();
            break;

        case 3: Console.WriteLine(Calcular.Multiplicar());
            salir = Repetir.salir();
            break;

        case 4: Console.WriteLine(Calcular.Dividir());
            salir = Repetir.salir();
            break;

        case 5: Console.WriteLine(Calcular.Potencia());
            salir = Repetir.salir();
            break;

        case 6: 
            Console.WriteLine("Nos vemos en la proxima.");
            Console.ReadLine();
            return;

        default: Console.WriteLine("La opcion que ha seleccionado es incorrecta. " +
            "\npor favor seleccione una de las opciones que aparecen en el menu.\n");
        break;
    }

} while (salir == 1 || op < 1 || op > 6);

Console.WriteLine("Nos vemos en la proxima.");
Console.ReadLine();
