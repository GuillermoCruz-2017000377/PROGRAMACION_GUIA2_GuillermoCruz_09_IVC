Proceso Ejercicio_06_Trigonometria
	Definir grados, radianes, resultado Como Real
	Definir opcion Como Entero
	
	Escribir "Ingrese el ángulo en grados:"
	Leer grados
	
	radianes <- grados * PI / 180
	
	Escribir "1. Seno"
	Escribir "2. Coseno"
	Escribir "3. Tangente"
	Escribir "Seleccione una opción:"
	Leer opcion
	
	Segun opcion Hacer
		1:
			resultado <- Sen(radianes)
			Escribir "Seno: ", resultado
		2:
			resultado <- Cos(radianes)
			Escribir "Coseno: ", resultado
		3:
			resultado <- Tan(radianes)
			Escribir "Tangente: ", resultado
		De Otro Modo:
			Escribir "Opción no válida"
	FinSegun
FinProceso
