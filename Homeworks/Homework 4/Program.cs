// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void expon(int a, int b)
// {
//     int count = 1;
//     int result = a;
//     while (count < b)
//     {
//         result = result * a;
//         count = count + 1;
//     }
//     Console.WriteLine("------------------");
//     Console.WriteLine(result);
    
// }

// Console.WriteLine("Enter A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter B");
// int b = Convert.ToInt32(Console.ReadLine());

// expon(a, b);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void sumNambers(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     Console.WriteLine($"sum = {sum}");
// }

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());
// sumNambers(number);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] inputArray()
// {
//     int[] array = new int[8];
//     for(int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//     }
//     return array;
// }

// void outputArray(int[] array)
// {
//     for(int i = 0; i < 8; i++)
//     {
//         Console.Write($"{array[i]}   ");
//     }
// }

// int[] array = inputArray();
// outputArray(array);
