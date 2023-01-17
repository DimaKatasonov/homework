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