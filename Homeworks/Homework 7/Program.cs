// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] InputArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     for(int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//                 array[i,j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
//         }
//         return array;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
   
// }

// Console.WriteLine("Введите число строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowArray(InputArray(m,n));




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.


// int[,] InputArray()
// {
//     int[,] array = new int[4,4];
//     for(int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 4; j++)
//                 array[i,j] = new Random().Next(10);
//         }
//         return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
   
// }

// void CheckNumber(int[,] array, int m, int n)
// {
//     if(m > array.GetLength(0) || n > array.GetLength(1)) Console.WriteLine("Такого числа нет в массиве");
//     else Console.WriteLine(array[m-1, n-1]);
// }

// int[,] array = InputArray();

// ShowArray(array);

// Console.WriteLine("Введите номер строки");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int n = Convert.ToInt32(Console.ReadLine());

// CheckNumber(array, m, n);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// int[,] InputArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for(int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//                 array[i,j] = new Random().Next(10);
//         }
//         return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
   
// }

// void MidNumbers(int[,] array)
// {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//       double sum = 0;
//       for(int i = 0; i < array.GetLength(0); i++)
//       {
//         sum += array[i,j];
//       }
//       double srnum = sum / array.GetLength(0);
//       Console.WriteLine($"Среднее арифмитическое {j+1} - ого столбца ===>  {srnum}");
//    }
// }

// Console.WriteLine("Введите кол-во строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = InputArray(m,n);
// ShowArray(array);
// MidNumbers(array);


