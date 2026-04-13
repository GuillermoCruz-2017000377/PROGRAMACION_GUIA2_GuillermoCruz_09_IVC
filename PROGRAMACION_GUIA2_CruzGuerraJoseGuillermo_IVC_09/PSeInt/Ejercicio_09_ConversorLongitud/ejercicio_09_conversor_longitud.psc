Proceso Ejercicio_09_ConversorLongitud
	Definir cantidad, enMetros, resultado Como Real
	Definir origen, destino Como Entero
	
	Escribir "UNIDADES DE LONGITUD"
	Escribir "1. Metros"
	Escribir "2. Pies"
	Escribir "3. Centímetros"
	Escribir "4. Pulgadas"
	
	Escribir "Seleccione la unidad de origen:"
	Leer origen
	
	Escribir "Ingrese la cantidad:"
	Leer cantidad
	
	Escribir "Seleccione la unidad de destino:"
	Leer destino
	
	Segun origen Hacer
		1:
			enMetros <- cantidad
		2:
			enMetros <- cantidad / 3.28084
		3:
			enMetros <- cantidad / 100
		4:
			enMetros <- cantidad / 39.3701
		De Otro Modo:
			Escribir "Unidad de origen no válida"
	FinSegun
	
	Si origen >= 1 Y origen <= 4 Entonces
		Segun destino Hacer
			1:
				resultado <- enMetros
				Escribir "Resultado: ", resultado, " metros"
			2:
				resultado <- enMetros * 3.28084
				Escribir "Resultado: ", resultado, " pies"
			3:
				resultado <- enMetros * 100
				Escribir "Resultado: ", resultado, " centímetros"
			4:
				resultado <- enMetros * 39.3701
				Escribir "Resultado: ", resultado, " pulgadas"
			De Otro Modo:
				Escribir "Unidad de destino no válida"
		FinSegun
	FinSi
FinProceso
