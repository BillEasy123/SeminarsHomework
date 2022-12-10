// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] InputArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(100);
//         }
//     }
//     return array;    
// }

// void ShowArray(int[,]array, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     } 
// }

// int[,] OrderNumbers(int[,]array, int m, int n)
// {
//     int tempNumber;
//     for (int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             int checkIndex = j + 1;
//             while(checkIndex < n)
//             {
//                 if(array[i,j] < array[i,checkIndex])
//                 {
//                     tempNumber = array[i,j];
//                     array[i,j] = array[i,checkIndex];
//                     array[i,checkIndex] = tempNumber;
//                 }
//                 checkIndex++;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] array = InputArray(m,n);
// ShowArray(array, m, n);
// array = OrderNumbers(array, m, n);
// Console.WriteLine("----------------------------");
// ShowArray(array, m, n);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] InputArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(100);
//         }
//     }
//     return array;    
// }

// void ShowArray(int[,]array, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     } 
// }

// void Minsumnumbers(int[,] array, int m, int n)
// {
//     int minLineIndex = 0;
//     int[] sumNumbers = new int[m];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             sumNumbers[i] += array[i,j];
//         }
//     }

//     for(int i = 1; i < m; i++){
//         if (sumNumbers[i] < sumNumbers[minLineIndex]) minLineIndex = i;
//     }

//     Console.WriteLine($"Минимальная сумма элементов в строке -------> {minLineIndex+1}");
// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = InputArray(m,n);
// ShowArray(array, m, n);
// Console.WriteLine("----------------------------");
// Minsumnumbers(array, m, n);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int[,] InputArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(10);
//             // Console.WriteLine("Введите значение "+ (i+1) + "," + (j+1));
//             // array[i,j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return array;    
// }

// void ShowArray(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     } 
// }

// int[,] Multmatrix(int[,] array1, int[,] array2, int m1, int n1, int n2)
// {

//     int[,] array3 = new int[m1, n2];
//     int index;
//     for (int i= 0; i < m1; i++)
//     {
//         for (int j = 0; j < n2; j++)
//         {
//             index = 0;
//             while(index < n1)
//             {  
//                 array3[i,j] += array1[i,index] * array2[index,j];
//                 index++;
//             }         
//         }
//     }    
//     return array3;

// }


// Console.WriteLine("Введите количество строк 1-ой матрицы");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1-ой матрицы");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк 2-ой матрицы");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 2-ой матрицы");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = InputArray(m1, n1);
// int[,] matrix2 = InputArray(m2, n2);

//   Console.WriteLine("Матрица А");  
//   ShowArray(matrix1);
//   Console.WriteLine("");

//   Console.WriteLine("Матрица В");  
//   ShowArray(matrix2);
//   Console.WriteLine("--------------------");

// if(n1 == m2) 
// {
//   int[,] matrix3 = Multmatrix(matrix1, matrix2, m1, n1, n2);
//   Console.WriteLine("Матрица А х В");
//   ShowArray(matrix3);
// }

// else Console.WriteLine("Произведение матриц таких размерностей невозможно");



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.



// int[,,] InputArray(int m, int n, int z)
// {
//     int[] checkArray = new int[m*n*z];
//     int[,,] array = new int[m, n, z];
//     int index = 0;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for(int k = 0; k < z; k++ )
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//                 for (int checkIndex = 0; checkIndex < m*n*z;)
//                 {
//                     if (checkArray[checkIndex] == array[i,j,k]) 
//                     { 
//                         array[i, j, k] = new Random().Next(10, 100);  
//                         checkIndex = 0;
//                     } 
//                     else checkIndex++;
//                 }
//                 checkArray[index] = array[i, j, k];
//                 index++;
//             }
//         }
//     }
//     return array;    
// }

// void ShowArray(int[,,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k <array.GetLength(2); k++)
//             {
//             Console.Write(array[i,j,k] + "("+ i + "," +j + "," + k + ")  ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine("-----------------");
//     } 
// }

// Console.WriteLine("Введите размер А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер В");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер С");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("___________________");

// ShowArray(InputArray(a,b,c));

// Console.WriteLine("___________________");



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.



// int[,] InputArray(int n)
// {
//     int j = 0;
//     int i = 0;
//     int[,] array = new int[4,4];
//     array[i,j] = n;

//     while(j+1 < 4)
//     {
//         j++;
//         n++;
//         array[i,j] = n;
//     }

//     while(i+1 < 4)
//     {
//             i++;
//             n++;
//             array[i,j] = n;
//     }

//     while(j-1 >= 0)
//     {
//             j--;
//             n++;
//             array[i,j] = n;
//     }

//     while(array[i-1,j] == 0)
//     {
//             i--;
//             n++;
//             array[i,j] = n;
//     }

//       while(array[i,j+1] == 0)
//     {
//             j++;
//             n++;
//             array[i,j] = n;
//     }


//       while(array[i+1,j] == 0)
//     {
//             i++;
//             n++;
//             array[i,j] = n;
//     }


//     j--;
//     n++;
//     array[i,j] = n;  
    
//     return array;
// }



// void ShowArray(int[,]array)
// {
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
//             else Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     } 
// }

// Console.WriteLine("Первое число массива");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("-----------------------");
// ShowArray(InputArray(a));


