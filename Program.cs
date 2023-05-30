//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x = ReadInt("Введите координату X первой точки: ");
int y = ReadInt("Введите координату Y первой точки: ");
int z = ReadInt("Введите координату Z первой точки: ");
int x1 = ReadInt("Введите координату второй точки X: ");
int y1 = ReadInt("Введите координату второй точки Y: ");
int z1 = ReadInt("Введите координату второй точки Z: ");

int A = x1 - x;
int B = y1 - y;
int C = z - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}