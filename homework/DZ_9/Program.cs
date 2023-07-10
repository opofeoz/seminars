// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNum(int num)
// {
//     if(num>=1)
//     {
//         System.Console.Write(num + ", ");
//         PrintNum(num-1);

//     }
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintNum(num);
// System.Console.WriteLine();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int FindSumOfNumbres(int m, int n)
// {
//     int sum = m;
//     int sum2 = n;
//     if (m == n)
//     {
//         return 0;
//     }
//     if (m < n)
//     {
//         m++;
//         sum = m + FindSumOfNumbres(m, n);
//         return sum;
//     }
//     else 
//     {       
//         n++;
//         sum2 = n + FindSumOfNumbres(n, m);
//         return sum2;
//     }
// }

// void PrintSumOfNumbers(int m, int n)
// {
//     if (m < n)
//     {
//         Console.Write($"сумма натуральных элементов = {FindSumOfNumbres(m - 1, n)} в промежутке от {m} до {n}");
//         System.Console.WriteLine();
//     }
//     if (m > n)
//     {
//         Console.Write($"сумма натуральных элементов = {FindSumOfNumbres(n - 1,m)} в промежутке от {m} до {n}");
//         System.Console.WriteLine();
//     }
//     if (m == n)
//     {
//         Console.Write($"НЕТ чисел в промежутке от {m} до {n}");
//         System.Console.WriteLine();
//     }
// }



// System.Console.WriteLine("Input M");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintSumOfNumbers(m, n);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// void AkkermanFunction(int m, int n)
// {

//     System.Console.Write($"Akkerman Function ({m},{n}) -> {Akkerman(m, n)}");
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input M");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m, n);
