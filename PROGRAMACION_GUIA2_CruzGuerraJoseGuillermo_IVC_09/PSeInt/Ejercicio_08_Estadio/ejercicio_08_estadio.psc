Proceso Ejercicio_08_Estadio
	Definir sector, tipo, cantidad Como Entero
	Definir precio, total Como Real
	precio <- 0
	
	Escribir "SECTORES DEL ESTADIO"
	Escribir "1. Palco"
	Escribir "2. Tribuna"
	Escribir "3. Preferencia"
	Escribir "4. Generales"
	Escribir "Seleccione un sector:"
	Leer sector
	
	Segun sector Hacer
		1:
			precio <- 300
		2:
			Escribir "1. Tribuna Q100.00"
			Escribir "2. Tribuna Q125.00"
			Escribir "Seleccione el tipo de tribuna:"
			Leer tipo
			Segun tipo Hacer
				1:
					precio <- 100
				2:
					precio <- 125
				De Otro Modo:
					Escribir "Tipo de tribuna no válido"
			FinSegun
		3:
			Escribir "1. Preferencia Q50.00"
			Escribir "2. Preferencia Q75.00"
			Escribir "Seleccione el tipo de preferencia:"
			Leer tipo
			Segun tipo Hacer
				1:
					precio <- 50
				2:
					precio <- 75
				De Otro Modo:
					Escribir "Tipo de preferencia no válido"
			FinSegun
		4:
			Escribir "1. General Q30.00"
			Escribir "2. General Q50.00"
			Escribir "Seleccione el tipo de general:"
			Leer tipo
			Segun tipo Hacer
				1:
					precio <- 30
				2:
					precio <- 50
				De Otro Modo:
					Escribir "Tipo de general no válido"
			FinSegun
		De Otro Modo:
			Escribir "Sector no válido"
	FinSegun
	
	Si precio > 0 Entonces
		Escribir "Ingrese la cantidad de entradas:"
		Leer cantidad
		total <- precio * cantidad
		Escribir "Precio por entrada: Q", precio
		Escribir "Cantidad de entradas: ", cantidad
		Escribir "Total a pagar: Q", total
	FinSi
FinProceso
