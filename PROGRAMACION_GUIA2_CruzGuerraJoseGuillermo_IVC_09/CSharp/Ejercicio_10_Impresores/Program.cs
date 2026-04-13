using System;

class Program
{
    static void Main()
    {
        int cantidad, formaPago;
        double precioSinIva = 650;
        double iva = 0.12;
        double precioConIva;
        double totalSinDescuento;
        double descuento = 0;
        double montoDescuento = 0;
        double totalPagar;
        string nombrePago = "";

        Console.Write("Ingrese la cantidad de impresores a comprar: ");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Formas de pago");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta de crédito");
        Console.WriteLine("3. Vale de regalo");
        Console.Write("Seleccione una opción: ");
        formaPago = int.Parse(Console.ReadLine());

        precioConIva = precioSinIva + (precioSinIva * iva);
        totalSinDescuento = precioConIva * cantidad;

        switch (formaPago)
        {
            case 1:
                nombrePago = "Efectivo";
                descuento = 0.10;
                break;
            case 2:
                nombrePago = "Tarjeta de crédito";
                descuento = 0.05;
                break;
            case 3:
                nombrePago = "Vale de regalo";
                descuento = 0.15;
                break;
            default:
                Console.WriteLine("Forma de pago no válida");
                break;
        }

        if (formaPago >= 1 && formaPago <= 3)
        {
            montoDescuento = totalSinDescuento * descuento;
            totalPagar = totalSinDescuento - montoDescuento;

            Console.WriteLine("Cantidad de impresores: " + cantidad);
            Console.WriteLine("Precio unitario con IVA: Q" + precioConIva);
            Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
            Console.WriteLine("Forma de pago: " + nombrePago);
            Console.WriteLine("Descuento realizado: Q" + montoDescuento);
            Console.WriteLine("Total a pagar: Q" + totalPagar);
        }
    }
}
