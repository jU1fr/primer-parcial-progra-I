using System;

class Programa
{
    static void Main(string[] args)
    {
        float numero, suma = 0, contador = 0;
        float promedio;

        Console.Write("Ingresa un número (0 para salir): ");
        numero = float.Parse(Console.ReadLine());

        while (numero != 0)
        {
            suma += numero;
            contador++;

            Console.Write("Ingresa otro número (0 para salir): ");
            numero = float.Parse(Console.ReadLine());
        }

        if (contador > 0)
        {
            promedio = suma / contador;
            Console.WriteLine("La suma de todos los números es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);
        }
        else
        {
            Console.WriteLine("No ingresaste números");
        }
    }
}