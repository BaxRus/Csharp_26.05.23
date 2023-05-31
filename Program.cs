// Семинар от 26.05.23

//Каждое задание выполняемое на семинаре и ДЗ выполняется в отдельной ветки.



/*
//Задача 19 (branch task_1)
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

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

//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{
    Console.Write("N"+i+"= "+i*i*i+" ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача №17. Напишите программу, которая принимает
//  на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер
// четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int Y = Convert.ToInt32(Console.ReadLine());

if((X>0) && (Y>0))
{
    Console.WriteLine("1");
}
else if((X<0) && (Y>0))
{
    Console.WriteLine("2");
}
else if((X<0) && (Y<0))
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("4");
}

//Напишите программу,
//которая по заданному номеру четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y).

Console.WriteLine("Введите число от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else if (num == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else if (num == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else if (num == 4)
{
    Console.WriteLine("X>0, Y<0");
}
else
{
    Console.WriteLine("Ввели некоректное число");
}

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

// Задача №17. Напишите программу, которая принимает
//  на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер
// четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:
    {
        Console.WriteLine("X>0, Y>0");
        break;
    }
    case 2:
    {
        Console.WriteLine("X<0, Y>0");
        break;
    }
    case 3:
    {
        Console.WriteLine("X<0, Y<0");
        break;
    }
    case 4:
    {
        Console.WriteLine("X>0, Y<0");
        break;
    }
    default:
    {
        Console.WriteLine("Ввели некоректное число");
        break;
    }

}

*/