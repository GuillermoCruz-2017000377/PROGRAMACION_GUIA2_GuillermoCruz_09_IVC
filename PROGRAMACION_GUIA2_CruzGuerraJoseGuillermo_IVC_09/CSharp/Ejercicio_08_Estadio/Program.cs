using System;

class Program
{
    static void Main()
    {
        int sector, tipo = 0, cantidad;
        double precio = 0, total;

        Console.WriteLine("SECTORES DEL ESTADIO");
        Console.WriteLine("1. Palco");
        Console.WriteLine("2. Tribuna");
        Console.WriteLine("3. Preferencia");
        Console.WriteLine("4. Generales");
        Console.Write("Seleccione un sector: ");
        sector = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                Console.WriteLine("1. Tribuna Q100.00");
                Console.WriteLine("2. Tribuna Q125.00");
                Console.Write("Seleccione el tipo de tribuna: ");
                tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        precio = 100;
                        break;
                    case 2:
                        precio = 125;
                        break;
                    default:
                        Console.WriteLine("Tipo de tribuna no válido");
                        break;
                }
                break;

            case 3:
                Console.WriteLine("1. Preferencia Q50.00");
                Console.WriteLine("2. Preferencia Q75.00");
                Console.Write("Seleccione el tipo de preferencia: ");
                tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        precio = 50;
                        break;
                    case 2:
                        precio = 75;
                        break;
                    default:
                        Console.WriteLine("Tipo de preferencia no válido");
                        break;
                }
                break;

            case 4:
                Console.WriteLine("1. General Q30.00");
                Console.WriteLine("2. General Q50.00");
                Console.Write("Seleccione el tipo de general: ");
                tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        precio = 30;
                        break;
                    case 2:
                        precio = 50;
                        break;
                    default:
                        Console.WriteLine("Tipo de general no válido");
                        break;
                }
                break;

            default:
                Console.WriteLine("Sector no válido");
                break;
        }

        if (precio > 0)
        {
            Console.Write("Ingrese la cantidad de entradas: ");
            cantidad = int.Parse(Console.ReadLine());
            total = precio * cantidad;

            Console.WriteLine("Precio por entrada: Q" + precio);
            Console.WriteLine("Cantidad de entradas: " + cantidad);
            Console.WriteLine("Total a pagar: Q" + total);
        }
    }
}
