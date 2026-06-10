
// Programa, area del rectangulo
double ladoA, ladoB, resultado;

Console.WriteLine("Calcula el Área de un Rectangulo!");
Console.WriteLine("Ingresa el valor del lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el valor del lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("El lado A: " + ladoA + " por El lado B: " + ladoB +  " Resulta en: " + resultado);


// Para convertir a int puede ser Convert.ToInt32() o Convert.ToInt64()
