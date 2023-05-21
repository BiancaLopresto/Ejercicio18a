namespace Ejercicio18a.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int Suma;
            int Resta;
            double Division;
            int Multiplicacion;

            Console.Write("Ingrese el valor del primer numero: ");
            numero1= int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor del segundo numero: ");
            numero2= int.Parse(Console.ReadLine());

            Suma = numero1 + numero2;
            Resta= numero1 - numero2;
            Multiplicacion = numero1 * numero2;

            if (numero2 == 0)
            {
                Console.Write("No se puede dividir por cero ");
            }
            else
            {
                Division=numero1 / numero2;
                Console.Write($"La Division es {Division} ");
            }

            Console.Write($"La Suma es {Suma} ");
            Console.Write($"La Resta es {Resta} ");
            Console.Write($"La Multiplicacion es {Multiplicacion} ");
        }
    }
}