// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задайте значения M и N
//         Console.Write("Введите значение для M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение для N: ");
//         int n = int.Parse(Console.ReadLine());

//         // Вывод натуральных чисел между M и N с помощью рекурсии
//         PrintNumbersInRange(m, n);
//     }

//     static void PrintNumbersInRange(int m, int n)
//     {
//         // Базовый случай: останавливать рекурсию, когда m больше n
//         if (m > n)
//             return;

//         // Вывод текущего значения m
//         Console.WriteLine(m);

//         // Рекурсивный вызов со следующим натуральным числом
//         PrintNumbersInRange(m + 1, n);
//     }
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Определение значений m и n
//         Console.Write("Введите значение для m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение для n: ");
//         int n = int.Parse(Console.ReadLine());

//         // Вычисление и отображение результата функции Аккермана
//         int result = Ackermann(m, n);
//         Console.WriteLine($"Ackermann({m}, {n}) = {result}");
//     }

//     static int Ackermann(int m, int n)
//     {
//         // Базовые случаи
//         if (m == 0)
//             return n + 1;
//         if (m > 0 && n == 0)
//             return Ackermann(m - 1, 1);

//         // Рекурсивный случай
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Определение произвольного массива
//         int[] numbers = { 1, 2, 3, 4, 5 };

//         // Вывод элементов массива, начиная с конца, с помощью рекурсии
//         PrintArrayFromEnd(numbers, numbers.Length - 1);
//     }

//     static void PrintArrayFromEnd(int[] array, int index)
//     {
//         // Базовый случай: останавливать рекурсию, когда индекс меньше 0
//         if (index < 0)
//             return;

//         // Вывод текущего элемента
//         Console.WriteLine(array[index]);

//         // Рекурсивный вызов с предыдущим индексом
//         PrintArrayFromEnd(array, index - 1);
//     }
// }
