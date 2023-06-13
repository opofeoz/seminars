// урок 1
//System.Console.WriteLine("Hello, World!!!");

//int a = 7;  //целые числа, без значиний после запятой
//int b = 5;
//int c = a / b;
//System.Console.WriteLine(c);

//double A = 7;  //дробные числа, со значением после запятой
//double B = 5;
//double C = A / B;
//System.Console.WriteLine(C);

//int d = Convert.ToInt32(Console.ReadLine()); //преобразуем вводные данные в числовое значение
// Console.ReadLine(""); //вводные данные от пользователя
//System.Console.WriteLine(d);

// задача 1. вычислить квадрат числа, с вводом числа от пользователя

// System.Console.Write("Введите число, квадрат которого хотите увидеть "); //вводим число
// int num = Convert.ToInt32(Console.ReadLine()); //преобразуем вводные данные в числовые

// int kvadrat = num * num; // можно через переменную kvadrat
// System.Console.WriteLine(kvadrat);

// System.Console.WriteLine(num * num); // можно без переменной

// System.Console.WriteLine("Квадрат числа " + num + " равен " + num * num); // изменяем вывод 
// System.Console.WriteLine($"Квадрат числа {num} равен {num * num}"); // тоже самое только иначе

// задача 2. дается два числа, узнать яв-ся ли первое число квадратом второго?


// System.Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//     System.Console.WriteLine($"Первое число {num1} является квадратом {num2}");
// }
// else
// {
//     System.Console.WriteLine($"Первое число {num1} не является квадратом {num2}");
// }

// задача 3.
// написать программу, которая принимает число N и выводит последовательность чисел от -N до N

// System.Console.Write("Введите число N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);
// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current++;
// }
// System.Console.WriteLine();

// задача 4.
// дано 3-х значное число, нужно вывести последнюю цифру этого числа
// System.Console.Write("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num < 1000 || num <= -100 && num > -1000)
// {
//     //System.Console.WriteLine($"Первая цифра числа {num} -> {num / 100}");
//     //System.Console.WriteLine($"Вторая цифра числа {num} -> {(num / 10) % 10}");
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 10}"); 
// }
// else
// {
//     System.Console.WriteLine("Число не является трехзначным!");
// }








