var radio = 0d;
var resultadoCirculo = 0d;

const double Pi = 3.14;

Console.WriteLine("Cálculo del área del circulo");
Console.WriteLine("Ingrese el valor del radio:");
radio = Convert.ToDouble(Console.ReadLine());

resultadoCirculo = Pi * radio * radio;

Console.WriteLine("El radio del círculo es: " + radio + ", el área es: " + resultadoCirculo);