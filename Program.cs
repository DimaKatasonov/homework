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

