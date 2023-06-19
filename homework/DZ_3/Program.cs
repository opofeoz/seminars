//Задача 19. Напишите программу, которая принимает на вход пятизначное число и
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int number)
// {
//     if (number >= 10000 && number < 100000)
//     {
//         int num1 = number % 10;
//         int num2 = (number / 10000) % 10;
//         if (num1 == num2)
//         {
//             int num3 = (number / 10) % 10;
//             int num4 = (number / 1000) % 10;
//             if (num3 == num4)
//             {
//                 System.Console.WriteLine($"число {number} ПАЛИНДРОМ!!!");
//             }
//             else
//             {
//                 System.Console.WriteLine($"число {number} не является ПАЛИНДРОМОМ!!!");
//             }
//         }
//         else
//         {
//             System.Console.WriteLine($"число {number} не является ПАЛИНДРОМОМ!!!");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"ошибка!!! число {number} не является пятизначным!!!");
//     }
// }

// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrom(number);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }
// System.Console.WriteLine("Input X coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Z coordinate point A: ");
// double za = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input X coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Y coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input Z coordinate point B: ");
// double zb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine($"Distance between points A and B -> {FindDistance(xa, ya, za, xb, yb, zb)}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quad(int N)
// {
//     int count = 1;
//     while (count <= N)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
//         count ++;
//     }
// }
// System.Console.WriteLine("Enter a number N -> ");
// int N = Convert.ToInt32(Console.ReadLine());
// Quad(N);









