// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void polindrom(int num)
// {
//     if (num % 10 == num / 10000 && (num / 1000) % 10 == (num / 10) % 10) Console.WriteLine("Yes"); 
//     else Console.WriteLine("No"); 
    
// }

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 1000 && number < 100000)
// {
//     Console.Write($"{number} ==> "); 
//     polindrom(number);
// } else Console.Write("Nevernoe chislo"); 


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double DistBeetPoint (int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2)); 
//     return result;
// } 

// Console.WriteLine("Enter x1, y1, z1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Enter x2, y2, z2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("___________________________");

// Console.WriteLine("Distance = " + DistBeetPoint(x1, y1, z1, x2, y2, z2));

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void cube(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.WriteLine($"{i} = > {i * i * i} ");
//     }
// }

// Console.WriteLine("Enter N");
// int N = Convert.ToInt32(Console.ReadLine());

// cube(N);
