namespace Calculadora
{
    public class Calcular
    {
        public static double Suma()
        {
            Titulo.msg("sumar");
            int count = Convert.ToInt16(Console.ReadLine());

            double[] num = new double[count];
            double total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Inserte el valor {i + 1}: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                total += num[i];
            }

            return total;
        }

        public static double Resta()
        {
            Titulo.msg("restar");
            int count = Convert.ToInt16(Console.ReadLine());

            double[] num = new double[count];
            double total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Inserte el valor {i + 1}: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            total = num[0];

            for(int j = 0; j < num.Length-1; j++)
            {
                total -= num[j+1];
            }

            return total;
        }

        public static double Multiplicar()
        {
            Titulo.msg("multiplicar");
            int count = Convert.ToInt16(Console.ReadLine());

            double[] num = new double[count];
            double total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Inserte el valor {i + 1}: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            total = num[0];

            for (int j = 0; j < num.Length - 1; j++)
            {
                total *= num[j + 1];
            }

            return total;
        }

        public static double Dividir()
        {
            Console.Write("Digite el primer valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el segundo valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1/num2;
        }

        public static double Potencia()
        {
            Console.Write("Va a digitar los siguientes valores \nprimero la base \ny luego el exponente.\n\n");

            double num = 0;
            double exponente = 0;
            double total= 0;

            Console.Write("Inserte el valor base: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte el valor del exponente: ");
            exponente = Convert.ToDouble(Console.ReadLine());

            total = Math.Pow(num, exponente);

            return total;
        }
    }
}
