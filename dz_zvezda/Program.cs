//На столе лежат n монеток. Некоторые из них лежат вверх решкой,
//а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
//чтобы все монетки были повернуты вверх одной и той же стороной.
//1-Решка
//0-Орел
Console.Clear();
Console.WriteLine("Первая монетка орел (0) или решка (1)? ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая монетка орел (0) или решка (1)? ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Третья монетка орел (0) или решка (1)? ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Четвертая монетка орел (0) или решка (1)? ");
int num4 = int.Parse(Console.ReadLine());
Console.WriteLine("Пятая монетка орел (0) или решка (1)? ");
int num5 = int.Parse(Console.ReadLine());
int sum_num = num1 + num2 + num3 + num4 + num5;

if (sum_num < 3)
    Console.WriteLine($"{sum_num}Переворачиваем все монетки орлом вверх! ");

else if (num1 > 1 || num1 < 0)
    Console.WriteLine("Ввели неправельные данные");
else if (num2 > 1 || num2 < 0)
    Console.WriteLine("Ввели неправельные данные");
else if (num3 > 1 || num3 < 0)
    Console.WriteLine("Ввели неправельные данные");
else if (num4 > 1 || num4 < 0)
    Console.WriteLine("Ввели неправельные данные");
    else if (num5 > 1 || num5 < 0)
    Console.WriteLine("Ввели неправельные данные");
else 
    Console.WriteLine($"{sum_num}Переворачиваем все монетки решкой вверх! ");
