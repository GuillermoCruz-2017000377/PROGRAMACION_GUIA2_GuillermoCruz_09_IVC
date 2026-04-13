Proceso Ejercicio_10_Impresores
	Definir cantidad, formaPago Como Entero
	Definir precioSinIva, iva, precioConIva Como Real
	Definir totalSinDescuento, descuento, montoDescuento, totalPagar Como Real
	Definir nombrePago Como Caracter
	
	precioSinIva <- 650
	iva <- 0.12
	descuento <- 0
	nombrePago <- ""
	
	Escribir "Ingrese la cantidad de impresores a comprar:"
	Leer cantidad
	
	Escribir "Formas de pago"
	Escribir "1. Efectivo"
	Escribir "2. Tarjeta de crédito"
	Escribir "3. Vale de regalo"
	Escribir "Seleccione una opción:"
	Leer formaPago
	
	precioConIva <- precioSinIva + (precioSinIva * iva)
	totalSinDescuento <- precioConIva * cantidad
	
	Segun formaPago Hacer
		1:
			nombrePago <- "Efectivo"
			descuento <- 0.10
		2:
			nombrePago <- "Tarjeta de crédito"
			descuento <- 0.05
		3:
			nombrePago <- "Vale de regalo"
			descuento <- 0.15
		De Otro Modo:
			Escribir "Forma de pago no válida"
	FinSegun
	
	Si formaPago >= 1 Y formaPago <= 3 Entonces
		montoDescuento <- totalSinDescuento * descuento
		totalPagar <- totalSinDescuento - montoDescuento
		
		Escribir "Cantidad de impresores: ", cantidad
		Escribir "Precio unitario con IVA: Q", precioConIva
		Escribir "Total sin descuento: Q", totalSinDescuento
		Escribir "Forma de pago: ", nombrePago
		Escribir "Descuento realizado: Q", montoDescuento
		Escribir "Total a pagar: Q", totalPagar
	FinSi
FinProceso
