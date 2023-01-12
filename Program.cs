// однострочный комменатрий 

/*Шаблон "Консольное приложение" успешно создан.

Идет обработка действий после создания...
Выполнение "dotnet restore" для C:\Users\dmkat\OneDrive\Рабочий стол\Proga1\Proga1.csproj...
  Определение проектов для восстановления...
  Восстановлен C:\Users\dmkat\OneDrive\Рабочий стол\Proga1\Proga1.csproj (за 125 ms).
Восстановление выполнено.


PS C:\Users\dmkat\OneDrive\Рабочий стол\Proga1>
 *  Журнал восстановлен 

PS C:\Users\dmkat\OneDrive\Рабочий стол\Proga1> 
*/

// Идет обработка действий после создания...
// Выполнение "dotnet restore" для C:\Users\dmkat\OneDrive\Рабочий стол\Proga1\Proga1.csproj...
// Определение проектов для восстановления...
// Восстановлен C:\Users\dmkat\OneDrive\Рабочий стол\Proga1\Proga1.csproj (за 125 ms).
// Восстановление выполнено

/* Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));


Console.WriteLine($"Квадрат числа {number} является число {sqr}, с библиотекой число {sqr1}"); */

// Задача 2: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
/* Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = -num;

while(num1 <= num){
    Console.Write($"{num1} ");
    num1++;
} */

// Задача с семинара. 

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write ("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write ("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if(a == Convert.ToInt32(Math.Pow (b, 2))){
//     Console.WriteLine($"Число {a} является квадратом числа {b}");
// }
// else{
//     Console.WriteLine($"Число {a} не является квадратом числа {b}");
// };

//Задача по семинару 2 

// Console.Write("Введите номер дня недели: ");
// int num = int.Parse(Console.ReadLine()!);

// if(num == 3)
// {
//     Console.Write("Среда");
// }
// else if(num == 5)
// {
//     Console.Write("Пятница");
// }
// else
// {
//     Console.Write("Не среда и не пятница");
// }

// Задача по семинару 3 

// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// int result = num % 10; 
// Console.Write ($"Последняя цифра трехзначного числа {result}");


// Семинар 2. Работа на семинаре 

//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

//  456 -> 46

// int number = new Random().Next(100, 1000);
// int result = (number/100)*10 + number%10;
// Console.WriteLine($"{number} -> {result}");
// Console.WriteLine($"{number} -> {number/100}{number%10}");

/* int number = new Random().Next(10, 100);
Console.Write($"{number}");
int number1 = number/10; 
int number2 = number%10;
if (number1 > number2)
{
  Console.Write($"Большая цифра {number1} ");
}
else
{
   Console.Write($"Большая цифра {number2} ");
}
*/

// Console.Write ("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write ("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Clear();
// if (a%b==0){
//   Console.Write($"Число {a} кратно числу {b}");
// }
// else
//   Console.Write($"Числа {a} и {b} - не кратные с остатком {a%b}");

//Продолжаем работать на семинаре. 

// Console.Write ("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if ((number % 7 == 0) && (number % 23 == 0)){
//   Console.Write($"Число {number} кратно 7 и 23 одновременно");
// }
// else{
//   Console.Write($"Число {number} не кратно 7 и 23 одновременно");
// }

// 4 задача на семинаре 

// Console.Write ("Введите первое число: ");
// int first_number = int.Parse(Console.ReadLine()!);
// Console.Write ("Введите второе число: ");
// int second_number = int.Parse(Console.ReadLine()!);
// if ((first_number == Math.Pow(second_number, 2)) || (second_number == Math.Pow(first_number, 2)))
// {
//   Console.Write($"Квадрат числа");
// }
// else
// {
//   Console.Write($"Никакое число не явлется квадратом");
// }


// Работа на семинаре 3

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// switch (num)
// {
//     case 1:{
//         Console.WriteLine("Это понедельник");
//         break;
//     }
//     case 2:{
//         Console.WriteLine("Это вторник");
//         break;
//     }
//     default:{
//         Console.WriteLine("Ошибка!!!");
//         break;
//     }
// }

// Задача 2 на семинаре 
// Console.Write ("Введи X: ");
// int x = int.Parse(Console.ReadLine()!);

// Console.Write ("Введи Y: ");
// int y = int.Parse(Console.ReadLine()!);

// if (x > 0 && y > 0)
// {
//   Console.Write ($"Это первая четверть");
// }

// if (x < 0 && y > 0)
// {
//   Console.Write ($"Это вторая четверть");
// }

// if (x < 0 && y < 0)
// {
//   Console.Write ($"Это третья четверть");
// }

// if (x > 0 && y < 0)
// {
//   Console.Write ($"Это четвертая четверть");
// }

// Console.Write("Введите номер четверти ");
// int num = int.Parse(Console.ReadLine()!);
// switch (num)
// {
//   case 1:{
//     Console.Write($"В этой четверти X > 0 и Y > 0");
//     break;
//   }

//   case 2:{
//     Console.Write($"В этой четверти X < 0 и Y > 0");
//     break;
//   }

//   case 3:{
//     Console.Write($"В этой четверти X < 0 и Y < 0");
//     break;
//   }

//   case 4:{
//     Console.Write($"В этой четверти X > 0 и Y < 0");
//     break;
//   }

//   default:{
//     Console.Write($"Цифра введена неверно");
//     break;
//   }
// }


// Console.WriteLine("Введите координату X точки 1: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y точки 1: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату X точки 2: ");
// int num3 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y точки 2: ");
// int num4 = int.Parse(Console.ReadLine()!);
// double res = Math.Sqrt(Math.Pow(num3 - num1, 2) + Math.Pow(num4 - num2, 2));
// Console.Write($"Расстояние между точками: {res:f2}");

// Console.Write("Введите какое-то число: ");
// int num = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= num; i++)
// {
//   Console.Write($"{Math.Pow(i, 2)} ");
// }
