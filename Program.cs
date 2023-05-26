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