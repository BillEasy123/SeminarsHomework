//    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] InputArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}   ");
//         if(array[i] % 2 == 0) sum++;
//     }
//     Console.WriteLine();
//     Console.Write($"Sum even numbers = {sum}");
// }

// Console.WriteLine("Enter SIZE array");
// int size = Convert.ToInt32(Console.ReadLine());

// ShowArray(InputArray(size));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] InputArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}   ");
//         if(i % 2 != 0) sum += array[i];
//     }

//     Console.WriteLine();
//     Console.Write($"Sum even numbers = {sum}");
// }

// Console.WriteLine("Enter SIZE array");
// int size = Convert.ToInt32(Console.ReadLine());

// ShowArray(InputArray(size));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// int[] InputArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void DiffMaxMin(int[] array)
// {
//     int max = array[0];
//     int min = array[0];
//     for(int i = 0; i < array.Length; i++)

//     {
//         Console.Write($"{array[i]}   ");
//         if(array[i] > max) max = array[i];
//         else if(array[i] < min) min = array[i];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"DifferenceMaxMin = {max - min}");
// }

// Console.WriteLine("Enter SIZE array");
// int size = Convert.ToInt32(Console.ReadLine());

// DiffMaxMin(InputArray(size));