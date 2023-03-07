//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//задача от преподавателя)
//Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

while (true)
{
    int count = 0;
    string m = Console.ReadLine();
    if (m == "stop")
    {
        break;
    }
    int M = Convert.ToInt32(m);
    if (M > 0)
    {
        count++;
    }
}
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("b1 is: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("k1 is: ");
int k1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("b2 is: ");
int b2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("k2 is: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int x = (b2 - b1)/(k1-k2);
int y = k1*x + b1;
Console.WriteLine($"Result is ({x}:{y})");