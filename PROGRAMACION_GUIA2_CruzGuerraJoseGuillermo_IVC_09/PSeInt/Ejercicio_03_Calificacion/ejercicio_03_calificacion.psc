Proceso Ejercicio_03_Calificacion
	Definir letra Como Caracter
	
	Escribir "Ingrese una letra (A, B, C, D, F):"
	Leer letra
	letra <- Mayusculas(letra)
	
	Segun letra Hacer
		"A":
			Escribir "Excelente"
		"B":
			Escribir "Bueno"
		"C":
			Escribir "Regular"
		"D":
			Escribir "Deficiente"
		"F":
			Escribir "Reprobado"
		De Otro Modo:
			Escribir "Letra no válida"
	FinSegun
FinProceso
