using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número del 1 al 7: ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("El día es Lunes");
                break;
            case 2:
                Console.WriteLine("El día es Martes");
                break;
            case 3:
                Console.WriteLine("El día es Miércoles");
                break;
            case 4:
                Console.WriteLine("El día es Jueves");
                break;
            case 5:
                Console.WriteLine("El día es Viernes");
                break;
            case 6:
                Console.WriteLine("El día es Sábado");
                break;
            case 7:
                Console.WriteLine("El día es Domingo");
                break;
            default:
                Console.WriteLine("Número no válido");
                break;
        }
    }
}
