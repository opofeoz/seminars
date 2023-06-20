// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// bool ValidPower(int b)
// {
//     if (b < 0)
//     {
//         System.Console.WriteLine("ОШИБКА!!! Число B не должно быть < 0");
//         return false;
//     }
//     return true;
// }

// int FindPower(int a, int b)
// {
//     int power = 1;
//     for (int i = 0; i < b; i++)
//     {
//         power *= a;
//     }
//     return power;
// }
// System.Console.WriteLine("Input number A -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number B -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (ValidPower(b))
// {
//     System.Console.WriteLine($"{a} in power {b} is -> {FindPower(a, b)}");
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindSumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; num > 0; i++)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.WriteLine("Input number -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Number {num} Sum of digits -> {FindSumNumbers(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreateRandomArray(size, minValue, maxValue));












