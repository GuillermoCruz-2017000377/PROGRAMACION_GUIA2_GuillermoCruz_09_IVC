using System;

class Program
{
    static void Main()
    {
        string letra;

        Console.Write("Ingrese una letra (A, B, C, D, F): ");
        letra = Console.ReadLine().ToUpper();

        switch (letra)
        {
            case "A":
                Console.WriteLine("Excelente");
                break;
            case "B":
                Console.WriteLine("Bueno");
                break;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Letra no válida");
                break;
        }
    }
}
