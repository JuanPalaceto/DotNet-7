int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int e = 11;
int f = 3;
WriteLine($"e is {e}, f{f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

// Si el primer número es un double, entonces el resultado será doble en vez de entero
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g /f = {g / f}");

int p = 6;
p += 3;
p -= 3;
p *= 3;
p /= 3;