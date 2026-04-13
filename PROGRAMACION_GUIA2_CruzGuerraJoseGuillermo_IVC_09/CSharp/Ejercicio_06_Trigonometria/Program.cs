using System;

class Program
{
    static void Main()
    {
        double grados, radianes, resultado;
        int opcion;

        Console.Write("Ingrese el ángulo en grados: ");
        grados = double.Parse(Console.ReadLine());

        radianes = grados * Math.PI / 180;

        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");
        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = Math.Sin(radianes);
                Console.WriteLine("Seno: " + resultado);
                break;
            case 2:
                resultado = Math.Cos(radianes);
                Console.WriteLine("Coseno: " + resultado);
                break;
            case 3:
                resultado = Math.Tan(radianes);
                Console.WriteLine("Tangente: " + resultado);
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
