using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora con funciones");

        bool continuar = true;

        while (continuar)
        {
            double num1 = PedirNumero("Ingresa el primer número: ");
            double num2 = PedirNumero("Ingresa el segundo número: ");
            char operacion = PedirOperacion();

            double resultado = Calcular(num1, num2, operacion);

            Console.WriteLine($"Resultado: {resultado}");

            continuar = PreguntarSiContinua();
        }

        Console.WriteLine("¡Gracias por usar la calculadora!");
    }


    //Metodo para pedir un numero con validacion
    static double PedirNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada no valida. Ingresa un numero.");
        }
    }

    static char PedirOperacion()
    {
        while (true)
        {
            Console.Write("Elige una operacion (+, -, *, /): ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && "+-*/".Contains(input))
            {
                return input[0];
            }
            Console.WriteLine("Operacion invalida. Intentalo de nuevo.");
        }
    }

    static double Calcular(double num1, double num2, char operacion)
    {
        switch (operacion)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 == 0 ? double.NaN : num1 / num2;
            default: return 0;
        }
    }

    static bool PreguntarSiContinua()
    {
        Console.Write("¿Quieres hacer otra operacion? (S/N): ");
        return Console.ReadLine().Trim().ToUpper() == "S";
    }
}