// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// int m = new Random().Next(3,11);
// if(m >= 3 && m <= 4) {
//     Console.WriteLine($"Введите {m} числа: ");
// }
// else Console.WriteLine($"Введите {m} чисел:");
// int count = 0;
// for(int i = 1; i < m+1; i++) {
//     Console.Write($"{i}-e число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number > 0) count++;
// }
// Console.WriteLine($"Количество чисел > 0 равно: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.Write("Введите k1 первого уравнения: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b1 первого уравнения: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2 первого уравнения: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2 первого уравнения: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// void CheckLine(double k1, double b1, double k2, double b2) {
//     double x = 0;
//     double y = 0;
//     if(k1 == k2 && b1 != b2) Console.WriteLine("Линии параллельны");
//     else if(k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают");
//     else {
//         x = (b2-b1)/(k1-k2);
//         y = k1 * x + b1;
//         Console.Write($"Координаты точки пересечения равны: ({x}, {y})");
//     }
// }
// CheckLine(k1, b1, k2, b2);