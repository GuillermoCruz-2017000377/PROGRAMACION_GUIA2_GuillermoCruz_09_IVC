using System;

class Program
{
    static void Main()
    {
        double cantidad, enMetros = 0, resultado = 0;
        int origen, destino;

        Console.WriteLine("UNIDADES DE LONGITUD");
        Console.WriteLine("1. Metros");
        Console.WriteLine("2. Pies");
        Console.WriteLine("3. Centímetros");
        Console.WriteLine("4. Pulgadas");

        Console.Write("Seleccione la unidad de origen: ");
        origen = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        cantidad = double.Parse(Console.ReadLine());

        Console.Write("Seleccione la unidad de destino: ");
        destino = int.Parse(Console.ReadLine());

        switch (origen)
        {
            case 1:
                enMetros = cantidad;
                break;
            case 2:
                enMetros = cantidad / 3.28084;
                break;
            case 3:
                enMetros = cantidad / 100;
                break;
            case 4:
                enMetros = cantidad / 39.3701;
                break;
            default:
                Console.WriteLine("Unidad de origen no válida");
                break;
        }

        if (origen >= 1 && origen <= 4)
        {
            switch (destino)
            {
                case 1:
                    resultado = enMetros;
                    Console.WriteLine("Resultado: " + resultado + " metros");
                    break;
                case 2:
                    resultado = enMetros * 3.28084;
                    Console.WriteLine("Resultado: " + resultado + " pies");
                    break;
                case 3:
                    resultado = enMetros * 100;
                    Console.WriteLine("Resultado: " + resultado + " centímetros");
                    break;
                case 4:
                    resultado = enMetros * 39.3701;
                    Console.WriteLine("Resultado: " + resultado + " pulgadas");
                    break;
                default:
                    Console.WriteLine("Unidad de destino no válida");
                    break;
            }
        }
    }
}
