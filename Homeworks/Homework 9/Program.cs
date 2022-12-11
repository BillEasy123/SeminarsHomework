// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// void ShowNumbers(int N)
// {
//     if(N > 0) 
//     {
//         if(N >= 1) 
//         { 
//             Console.Write(N + " "); 
//             ShowNumbers(N-1);
//         }
//     }   
    
// }

// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(N);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNumbers(int M, int N)
// {
//     if (M == N) return M;
    
//     if (M < N)
//     {
//         M = M + SumNumbers(M+1, N);
//         return M;
//     } else
//     {
//         M = M + SumNumbers(M-1, N);
//         return M;
//     }

// }
    
// Console.WriteLine("Введите M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("SUM = " + SumNumbers(M, N));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



// int FuncAkker(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return FuncAkker(n - 1, 1);
//     else
//       return FuncAkker(n - 1, FuncAkker(n, m - 1));
// }

// Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FuncAkker(m,n));

