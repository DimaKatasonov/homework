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
