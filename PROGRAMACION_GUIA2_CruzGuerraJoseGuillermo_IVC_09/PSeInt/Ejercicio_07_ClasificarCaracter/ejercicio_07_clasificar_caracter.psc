Proceso Ejercicio_07_ClasificarCaracter
	Definir caracter Como Caracter
	
	Escribir "Ingrese un carácter:"
	Leer caracter
	caracter <- Minusculas(caracter)
	
	Segun caracter Hacer
		"a", "e", "i", "o", "u":
			Escribir "Es una vocal"
		"0", "1", "2", "3", "4", "5", "6", "7", "8", "9":
			Escribir "Es un dígito"
		De Otro Modo:
			Escribir "No es vocal ni dígito"
	FinSegun
FinProceso
