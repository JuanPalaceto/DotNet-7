WriteLine("int x = 3;");
WriteLine("int y = 2 + ++x;");

int x = 3;
int y = 2 + ++x;
WriteLine($"x = {x} and y = {y}");
WriteLine();

//Operador Descripción
//&	AND bitwise (y) - Devuelve un 1 en cada bit donde ambos operandos tengan un 1.
//|	OR bitwise (o) - Devuelve un 1 en cada bit donde al menos un operandos tengan un 1.
//^	XOR bitwise (o exclusivo) - Devuelve un 1 en cada bit donde uno de los operandos tenga un 1, pero no ambos.
//~	NOT bitwise (no) - Invierte los bits, convierte 0 a 1 y 1 a 0.
//<<	Desplazamiento a la izquierda - Desplaza los bits a la izquierda, llenando los nuevos bits con ceros. Trabajan con el int en el segundo parametro, es decir, 2 significa moverlos 2 digitos
//>>	Desplazamiento a la derecha con signo - Desplaza los bits a la derecha, llenando los nuevos bits con el bit de signo original (en este caso, el bit más significativo).
//>>> (no existe)	En C#, no hay un operador de desplazamiento a la derecha sin signo. Sin embargo, puedes lograr un efecto similar usando el operador de desplazamiento a la derecha con signo y manipulando los bits según sea necesario.

// Trabjaan a nivel de bits, es decir:
// 0001 (1) - 0011 (3) 
// 0001 & 0011 = 0001 (1)
// 0001 | 0011 = 0011 (3)
// 0001 ^ 0011 = 0010 (2)
// ~0000 0001 = 1111 1110 (254)
// 0001 << 0011 = 1000 (8)

WriteLine("x = 3 << 2;");
WriteLine("y = 10 >> 1;");

x = 3 << 2; // 0011 << 2 = 1100 = 12
y = 10 >> 1; // 1010 >> 1 = 0101 = 5
WriteLine($"x = {x} and y = {y}");
WriteLine();

WriteLine("x = 10 & 8;"); 
WriteLine("y = 10 | 7;"); 

x = 10 & 8; // 1010 && 1000 = 1000 = 8
y = 10 | 7; // 1010 && 0111 = 1111 = 15
WriteLine($"x = {x} and y = {y}");
WriteLine();