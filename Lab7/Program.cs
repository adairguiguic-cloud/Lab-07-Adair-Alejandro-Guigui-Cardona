using System;

class Program {
    static void Main() {
        Console.Write("Nombre: ");
        string n = Console.ReadLine();
        Console.WriteLine("Hola " + n);
        Console.WriteLine();

        Console.WriteLine("=== 1 ===");
        suma();
        Console.WriteLine();

        Console.WriteLine("=== 2 ===");
        conv();
        Console.WriteLine();

        Console.WriteLine("=== 3 ===");
        juego();
        Console.WriteLine();

        Console.WriteLine("=== 4 ===");
        pin();
    }

    static void suma() {
        int n;
        do {
            Console.Write("Cuántos?: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        int s = 0, i = 0;

        while (i < n) {
            Console.Write("Num " + (i+1) + ": ");
            s += int.Parse(Console.ReadLine());
            i++;
        }

        Console.WriteLine("Suma: " + s);
        Console.WriteLine("Prom: " + (double)s / n);
    }

    static void conv() {
        int op;
        do {
            Console.WriteLine("\n1) C->F");
            Console.WriteLine("2) F->C");
            Console.WriteLine("3) Km->Mi");
            Console.WriteLine("4) Salir");
            Console.Write("Op: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1) {
                Console.Write("C: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("F: " + ((c * 9 / 5) + 32).ToString("F2"));
            } 
            else if (op == 2) {
                Console.Write("F: ");
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine("C: " + ((f - 32) * 5 / 9).ToString("F2"));
            } 
            else if (op == 3) {
                Console.Write("Km: ");
                double km = double.Parse(Console.ReadLine());
                Console.WriteLine("Mi: " + (km / 1.60934).ToString("F2"));
            } 
            else if (op == 4) {
                Console.WriteLine("Bye");
            } 
            else {
                Console.WriteLine("Error");
            }

        } while (op != 4);
    }

    static void juego() {
        Random r = new Random();
        int x = r.Next(1, 101);
        int i = 0, n;

        Console.WriteLine("1-100");

        do {
            Console.Write("Intento: ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100) {
                Console.WriteLine("Fuera");
                continue;
            }

            i++;

            if (n < x) Console.WriteLine("Más");
            else if (n > x) Console.WriteLine("Menos");
            else Console.WriteLine("Bien (" + i + ")");
        } while (n != x);
    }

    static void pin() {
        int ok = 1234;
        int i = 0, p;
        bool acc = false;

        do {
            Console.Write("PIN: ");
            p = int.Parse(Console.ReadLine());
            i++;

            if (p == ok) {
                Console.WriteLine("OK");
                acc = true;
            } else {
                Console.WriteLine("Mal");
                if (i == 3) Console.WriteLine("Bloqueado");
            }

        } while (i < 3 && !acc);
    }
}