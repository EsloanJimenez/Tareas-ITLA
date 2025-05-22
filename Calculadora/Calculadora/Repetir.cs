namespace Calculadora
{
    public class Repetir
    {
        public static int salir()
        {
            Console.WriteLine("Desea hacer otra operacion.\n" +
            "1- SI\n" +
            "2- NO\n");
            int rep = Convert.ToInt32(Console.ReadLine());

            return rep;
        }
    }
}
