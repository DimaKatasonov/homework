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