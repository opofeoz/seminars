// int FindSum(int num1, int num2) // FindSum это метод
// {
//     int sum = num1 + num2;
//     return sum;
// }
// int x = 5;
// int y = 6;

// //int result = FindSum(x,y); // переменная result присваивает метод FindSum
// //System.Console.WriteLine(result);
// System.Console.WriteLine(FindSum(x, y));

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckEven(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"Число {num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {num2} некратно {num1}, остаток от деления -> {num1 % num2}");
//     }
// }
// System.Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckEven(num1, num2);

// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// bool CheckEven(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// System.Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));

// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// void SquareNumber(int num1, int num2)
// {
//     if (num1 == num2 * num2)
//     {
//         System.Console.WriteLine($"Число {num1} является квадратом числа {num2}");
//     }
//     else if (num2 == num1 * num1)
//     {
//         System.Console.WriteLine($"Число {num2} является квадратом числа {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($" НЕ одно из чисел не является квадратом друг друга ");
//     }
// }
// System.Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// SquareNumber(num1, num2);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int FindNum(int index)
// {
//     int num1 = index / 100;
//     int num2 = index % 10;
//     int result = num1 * 10 + num2;
//     return result;
// }
// int index = new Random().Next(100, 1000);
// System.Console.WriteLine(index);
// System.Console.WriteLine(FindNum(index));






















