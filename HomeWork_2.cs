// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите 1 число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2 число: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A}, возведенное в натуральную степень {B} = {num_degree(A, B)}");


// // -------------------Метод----------------


//  int num_degree(int a, int b)
//  {
//      int result = 1;
//      for(int i = 1; i <= b; i++)
//         {
//             result = result * a;
//         }
//      return result;
//  }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите число: ");
// int count = int.Parse(Console.ReadLine()!);
// Console.Write($"Сумма цифр числа {count} = {sumDigits(count)} ");
// Console.WriteLine();
// string count_new = count.ToString();
// Console.Write($"Сумма цифр числа {count} = {sum_of_digits(count_new)} ");

// // -------------------Метод----------------

// int sumDigits(int a)
// {
//     int s = 0;
//     while (a > 0)
//     {
//         s = s + a % 10;
//         a = a /10;
//     }
//     return s;
// }

// // -------------------Метод----------------

// int sum_of_digits(string num)       // К примеру, число: 6584 
// {
//     int result = 0; 
//     int i = 0;
//     while (num.Length > i)
//     {
//         string b = num[i].ToString();
//         int a = Convert.ToInt32(b);
//         result = result + a;
//         i = i + 1;
//     }
//     return result;
// }





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// (числа берете любые)

// int[] myArray = GetArray(8);
// Console.WriteLine($"[{String.Join(',', myArray)}]");

// // ------Метод------

// int[] GetArray(int size){
//     int[] myArray = new int[size];
//     for(int i = 0; i < size; i++){
//         myArray[i] = new Random().Next();
//     }
//     return myArray;
// }

// Домашние задания к семинару 5 


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] array = GetArray(20, 100, 999);
// Console.WriteLine($"[{String.Join ("," , array)}]");
// Console.WriteLine($"Количество чётных чисел в массиве {countEl(array)}");

// int countEl(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// // ----------Метод------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] array = GetArray(10, -100, 100);
// Console.WriteLine($"[{String.Join ("," , array)}]");
// Console.WriteLine($"Cумма элементов, стоящих на нечётных индексах: {sumIndex(array)} ");

// int sumIndex(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// // ----------Метод------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21



// int[] array = GetArray(5, -10, 10);
// Console.WriteLine($"[{String.Join ("," , array)}]");
// Console.WriteLine($"{String.Join ("," , SumIndex(array))}");


// int[] SumIndex(int[] array)
// {   
//     int size = array.Length / 2; 
//     if (array.Length % 2 == 1) size++; 
//     int[] result = new int [size];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         result[i] = array [i] * array[array.Length - 1 - i]; 
//     }
//     if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
//     return result;
// }

// // ----------Метод------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// ДЗ по 6 семинару 

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)


Console.WriteLine($"Введите числа, через пробел: ");
string stringArray = (Console.ReadLine()!);

string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);

numS[] = Convert.ToInt32();












// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

