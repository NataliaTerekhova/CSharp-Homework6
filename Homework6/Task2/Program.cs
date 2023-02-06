/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double b1= new Random().Next(1,11);
double k1= new Random().Next(1,11);
double b2= new Random().Next(1,11);
double k2= new Random().Next(1,11);

System.Console.WriteLine( $"b1={b1}, k1={k1}, b2={b2}, k2={k2}");

double x = (b2-b1)/(k1-k2);
double y =(k1*x) + b1;

//(k1*x) + b1= (k2*x) + b2;
 
System.Console.WriteLine( $"x={x}, y={y}");

if (x==y)
{
    System.Console.WriteLine("Прямые пересекаются в этой точке");
}
else 
{
System.Console.WriteLine("Прямые не пересекаются в этой точке");
}
