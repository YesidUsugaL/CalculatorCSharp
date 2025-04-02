using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora avanzada: ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz");
            Console.WriteLine("7. Salir");
            Console.Write("Elige una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
            {
                Console.WriteLine("Opcion no valida. Intentalo de nuevo.");
                Console.ReadKey();
                continue;
            }

            if (opcion == 7)
            {
                Console.WriteLine("Saliendo de la calculadora...");
                break;
            }

            Console.Write("Ingrese el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            double num2 = 0;

            if (opcion != 6)
            {
                Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = num1 / num2;
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 6:
                    resultado = Math.Pow(num1, 1.0 / num2);
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar... ");
            Console.ReadKey();
        }
    }
}
