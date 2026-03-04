using System;

namespace EjerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            E1();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E2();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E3();
            Console.WriteLine("\nPresione una tecla...");
            Console.ReadKey();

            E4();
            Console.WriteLine("\nFin del programa.");
            Console.ReadKey();
        }

        static void E1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            int n, c = 0;
            double num, s = 0;

            Console.Write("¿Cuántos números?: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Ingrese entero > 0: ");

            while (c < n)
            {
                Console.Write($"Número {c + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out num))
                    Console.Write("Número válido: ");

                s += num;
                c++;
            }

            Console.WriteLine($"Suma: {s}");
            Console.WriteLine($"Promedio: {s / n:F2}");
        }

        static void E2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            int op;
            double v, r;
            bool s = false;

            do
            {
                Console.WriteLine("\n1.C→F  2.F→C  3.Km→Mi  4.Salir");
                Console.Write("Opción: ");

                while (!int.TryParse(Console.ReadLine(), out op))
                    Console.Write("Número válido: ");

                switch (op)
                {
                    case 1:
                        Console.Write("Celsius: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = (v * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {r:F2} °F");
                        break;

                    case 2:
                        Console.Write("Fahrenheit: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = (v - 32) * 5 / 9;
                        Console.WriteLine($"Resultado: {r:F2} °C");
                        break;

                    case 3:
                        Console.Write("Kilómetros: ");
                        while (!double.TryParse(Console.ReadLine(), out v))
                            Console.Write("Número válido: ");
                        r = v * 0.621371;
                        Console.WriteLine($"Resultado: {r:F2} Millas");
                        break;

                    case 4:
                        s = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (!s);
        }

        static void E3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Random r = new Random();
            int na = r.Next(1, 101);
            int i, c = 0;
            bool ok = false;

            Console.WriteLine("Adivina el número (1-100)");

            while (!ok)
            {
                Console.Write("Intento: ");
                while (!int.TryParse(Console.ReadLine(), out i))
                    Console.Write("Número válido: ");

                if (i < 1 || i > 100)
                {
                    Console.WriteLine("Fuera de rango.");
                    continue;
                }

                c++;

                if (i < na)
                    Console.WriteLine("Más alto");
                else if (i > na)
                    Console.WriteLine("Más bajo");
                else
                {
                    ok = true;
                    Console.WriteLine($"Correcto en {c} intentos");
                }
            }
        }

        static void E4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            const int pc = 1234;
            const int mi = 3;
            int pi, c = 0;
            bool ok = false;

            do
            {
                Console.Write("PIN: ");
                while (!int.TryParse(Console.ReadLine(), out pi))
                    Console.Write("Número válido: ");

                c++;

                if (pi == pc)
                {
                    Console.WriteLine("Acceso concedido");
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    if (c < mi)
                        Console.WriteLine($"Intentos restantes: {mi - c}");
                }

            } while (c < mi && !ok);

            if (!ok)
                Console.WriteLine("Cuenta bloqueada");
        }
    }
}