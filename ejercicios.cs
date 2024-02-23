using System;

class Ejercicios
{
    public void EjerciciosBasicos()
    {
        // Operación de suma
        int suma = Sumar(5, 3);
        Console.WriteLine("Suma: " + suma);

        // Operación de resta
        int resta = Restar(8, 4);
        Console.WriteLine("Resta: " + resta);

        // Operación de multiplicación
        int multiplicacion = Multiplicar(6, 2);
        Console.WriteLine("Multiplicación: " + multiplicacion);

        // Operación de división
        double division = Dividir(10, 2);
        Console.WriteLine("División: " + division);

        Console.ReadLine();
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int Restar(int a, int b)
    {
        return a - b;
    }

    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static double Dividir(int a, int b)
    {
        if (b != 0)
        {
            return (double)a / b;
        }
        else
        {
            Console.WriteLine("Error: División por cero.");
            return double.NaN; // NaN (Not a Number) indica un resultado no válido.
        }
    
    }
}