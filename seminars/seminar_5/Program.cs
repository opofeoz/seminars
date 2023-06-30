﻿//Задача 1Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//сумма отрицательных равна -20.

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
// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     System.Console.WriteLine($"Sum of positive elements -> {sumPos} --- Sum of negative elements -> {sumNeg}");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// PosNegSum(myArray);



//Задача 2. Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// myArray = InvertArray(myArray);
// PrintArray(myArray);

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateArray(int size)
// {
//     System.Console.WriteLine("Введите числа массива -> ");
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) return true;
//     }
//     return false;
// }
// System.Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число для поиска");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// if (FindNumber(array,number))
// {
//     System.Console.WriteLine($"{number} -> есть в массиве");
// }
// else
// {
//     System.Console.WriteLine($"{number} -> нет в массиве");
// }


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

// int[] CreateArray()
// {
//     int[] array = new int[123];
//     for (int i = 0; i < 123; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
//     return array;
// }
// int FindNumOfElements(int[] array, int minValue, int maxValue)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > minValue && array[i] < maxValue)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.WriteLine(" ");
// }
// System.Console.WriteLine("Введите минимальное значение");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray();
// PrintArray(array);
// System.Console.WriteLine($"элементов в диапозоне от {minValue} до {maxValue} -> {FindNumOfElements(array, minValue, maxValue)}");