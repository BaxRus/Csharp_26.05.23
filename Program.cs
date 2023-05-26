// Напишите программу, которая принимает
// на вход координаты двух точек и находит
//  расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// d (X2-X1)*(X2-X1)+ (Y2-Y1)2

Console.WriteLine("Введите число");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число");
int Y2 = Convert.ToInt32(Console.ReadLine());

double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));

Console.WriteLine(d);