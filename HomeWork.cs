//Домашняя работа по 1 семинару. 
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.\

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write ("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write ("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if(a > b){
//     Console.Write ($"Большее число: {a} ");
//     Console.Write ($"Меньшее число: {b} ");
// }
// else if(b > a){
//     Console.Write ($"Большее число: {b} ");
//     Console.Write ($"Меньшее число: {a} ");
// }
// else
// {
//     Console.Write ($"Введите числа еще раз: ");
// }

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write ("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write ("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write ("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// Console.Clear();
// int max = a;
// if (max < b)
// {
//     max = b;
// }
// if (max < c)
// {
//     max = c;
// }
// Console.Write ($"Максимальное число {max}");


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write ("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num % 2 == 0){
//     Console.Write ($"Введенное число: {num} четное");
// }
// else {
//     Console.Write ($"Введенное число: {num} нечетное");
// }


// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введи число: ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = 1;
// while(num1 <= num){
//     if (num1 % 2 == 0) 
//     {
//          Console.Write($"{num1} ");
//     }
//     num1++;
// } 

//  Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков

//  456 -> 5
//  782 -> 8
//  918 -> 1

// Console.Write("Пожалуйста, введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = (num/10) % 10;
// if ((num <= 999) && (num > 99)){
//     Console.Write($"Вторая цифра числа {num1}");
// }
// else 
// {
//     Console.Write($"Попробуйте еще раз");
// }


// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Берем числа до 100000

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.Write("Пожалуйста, введите любое число до 100000: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num <= 99){
//     Console.Write($"Третьей цифры нет, попробуйте еще раз");
// }
// if ((num > 99) && (num <= 999))
// {
//     int num1 = num % 10;
//     Console.Write($"Третья цифра {num1}");
// }
// if ((num > 999) && (num <= 9999))
// {
//     int num2 = (num / 10) % 10; 
//     Console.Write($"Третья цифра {num2}");
// }
// if ((num > 9999) && (num <= 99999))
// {
//     int num3 = (num / 100) % 10;
//     Console.Write($"Третья цифра {num3}");
// }
// if ( num == 100000)
// {
//     Console.Write($"Третья цифра равна 0");
// }
// if (num > 100000)
// {
//      Console.Write($"Не подходит, введите меньшее число");
// }


//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. 
//Обязательна проверка на ввод числа <1 и >7

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Пожалуйста, введите номер дня недели, а я определю, выходной это или нет: ");
// int num = int.Parse(Console.ReadLine()!);
// if ((num >= 1) && (num <= 7))
// {
//     if (num <= 5)
//     {
//         Console.Write("Это будний день");
//     }  
//     else if ((num <= 7) && (num > 5))
//     {
//         Console.Write("Это выходной день");
//     }
// }
// else 
// {
//     Console.Write("Введите другую цифру");
// }

// Домашняя работа по 3-му семинару 

// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Проверка на пятизначность обязательна
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!); 
// string palindrome = Convert.ToString(num); 
// if (palindrome.Length == 5)
// {
//     if ((palindrome[0] == palindrome[4]) && (palindrome[1] == palindrome[3]))
//     {
//         Console.Write($"Число {num} является палиндромом ");
//     }
//     else {
//         Console.Write($"Число {num} не является палиндромом ");
//     }
// }
// else
// {
//     Console.Write($"Число введено неверно");
// }

// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X точки 1: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y точки 1: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z точки 1: ");
// int num3 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату X точки 2: ");
// int num4 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y точки 2: ");
// int num5 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z точки 2: ");
// int num6 = int.Parse(Console.ReadLine()!);
// double res = Math.Sqrt(Math.Pow(num4 - num1, 2) + Math.Pow(num5 - num2, 2) + Math.Pow(num6 - num3, 2));
// Console.Write($"Расстояние между точками: {res:f2}");


// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите любое число ");
// int cube = int.Parse(Console.ReadLine()!); 
// for (int i = 1; i <= cube; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");
// }
