// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
 /* int secondnumber(int number) 
 {
    int chis = number / 10;
    int result = chis % 10;
    return result;
 }

 int result = new Random().Next(100, 1000);

 Console.WriteLine(result + " ===> " + secondnumber(result)); */

 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/* int secondnumber(int number)
{
    while (number > 999)
    {
    number = number / 10;        
    }
    number = number % 10;
    return number;
}

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("Third number isn't"); 
else Console.WriteLine(num + " ===> " + secondnumber(num)); */

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/* bool holiday(int num)
{
    bool result;
    if (num == 6 || num == 7) result = true;
    else result = false;
    return result;
}

Console.WriteLine("Enter number day of the week");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number + " ===> " + holiday(number)); */