// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] array(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Введите " + (i+1) + " - ое число");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PossitiveNumbers(int[] array, int size)
// {
//     int sum = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] > 0) sum++;
//     }
//     Console.WriteLine("Положительных чисел ==> " + sum);
// }

// Console.WriteLine("Введите кол-во чисел");
// int size = Convert.ToInt32(Console.ReadLine());

// PossitiveNumbers(array(size), size);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



// double CoordinatesPointX(double b1, double k1, double b2, double k2)
// {
//     double result = (-1) * (b1 - b2)/(k1-k2);
//     return result;
// }

// double CoordinatesPointY(double x, double b1, double k1)
// {
//     double result = k1 * x + b1;
//     return result;
// }

// Console.WriteLine("Введите b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = CoordinatesPointX(b1, k1, b2, k2);
// double y = CoordinatesPointY(x, b1, k1);

// Console.WriteLine("----------------------------");
// Console.WriteLine("===>>(" + x + " ; " + y + ")");

