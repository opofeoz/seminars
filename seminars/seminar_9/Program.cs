﻿//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNum(int num)
// {
//     if(num>=1)
//     {
//         PrintNum(num-1);
//         System.Console.Write(num + " ");
//     }
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintNum(num);
// System.Console.WriteLine();


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

// int FindSum(int num)
// {
// if (num > 0)
// {
// return FindSum(num / 10) + num % 10;
// }
// else return num;
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindSum(num));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FindNumbres(int m, int n)
// {
//     if (m != n)
//     {
//         if (m < n)
//         {
//             FindNumbres(m, n - 1);
//             System.Console.Write(n + " ");
//         }
//         else
//         {
//             System.Console.Write(m + " ");
//             FindNumbres(m - 1, n);
//         }
//     }
//     else System.Console.Write(n + " ");
// }
// FindNumbres(10, 2);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.

// int FindNumbers(int a, int b)
// {
//     if (b > 0)
//     {

//         return FindNumbers(a, b - 1) * a;
//     }
//     else return 1;
// }
// System.Console.WriteLine(FindNumbers(2, 3));