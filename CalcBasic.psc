Algoritmo CalcBasic
	Definir opc Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "**********************"
	Escribir "*  MENU DE OPCIONES  *"
	Escribir "********************+*"
	Escribir "1-Suma."
	Escribir "2-Resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Division"
	Escribir Sin Saltar "Digite la opcion []:"
	Leer opc
	Escribir "Digite dos valores numericos:"
	Leer num1
	Leer num2
	Segun opc Hacer
		1:
			Escribir "La Suma es: ",(num1+num2)
		2:
			Escribir "La Resta es: ",(num1-num2)
		3::
			Escribir "La Multiplicacion es: ",(num1*num2)
		4:
			Escribir "La Division es: ",(num1/num2)
		De Otro Modo:
			Escribir "¡ERROR AL OPERAR LOS NUMEROS!"
	Fin Segun
	
FinAlgoritmo
