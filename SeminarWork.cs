// Задача 1

// Console.Write("Введите число: ");
// int limit = int.Parse(Console.ReadLine()!);
// Console.Write($"Сумма чисел от 1 до {limit}: {GetSum(limit)}");

// // ------------- Методы --------------
// int GetSum(int A){
//     int sum = 0;
//     for(int i = 1; i <= A; i++){
//         sum += i; // sum = sum + i
//     }
//     return sum;
// }


// // Задача 2 

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write($"Произведение чисел от 1 до {N}: {GetMultiply(N)}");

// // -------------------Метод----------------

// int GetMultiply(int N){
//     int mult = 1;
//     for(int i = 1; i <= N; i++){
//         mult = mult * i;
//     }
//     return mult;
// }


// // Задача 3 


// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.Write($"Количество цифр в числе {N}: {countNums(N)} ");
// string M = N.ToString();
// Console.Write($"Количество цифр в числе {M}: {countNums2(M)} ");

// // Метод 

// int countNums (int num){
//     int count = 0;
//     if ( num == 0) return 1; 
//     while (num > 0){
//         count++;
//         num = num / 10;
//     }
//     return count;
// }

// // Метод 

// int countNums2 (string num){
//     int a = num.Length;
//     return a;
// }


// // Задача 4 

// int[] myArray = GetArray(8);
// Console.WriteLine($"[{String.Join(',', myArray)}]");

// // ------Метод------

// int[] GetArray(int size){
//     int[] myArray = new int[size];
//     for(int i = 0; i < size; i++){
//         myArray[i] = new Random().Next(2);
//     }
//     return myArray;
// }

// Работа на семинаре 5 

// Задача 1 

// int[] array = GetArray(12, -9, 9);
// Console.WriteLine($"[{String.Join ("," , array)}]");

// int positiveSum = 0;
// int negativSum = 0; 

// foreach (int el in array)
// {
//     if (el > 0){
//         positiveSum += el;
//     }
//     else {
//         negativSum += el;
//     }
// }

// Console.WriteLine($"Сумма положительных чисел равна {positiveSum}, сумма отрицательных чисел равна {negativSum}");

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



// Задача 2 

// int[] array = GetArray(6, -100, 100);
// Console.WriteLine($"[{String.Join ("," , array)}]");
// for ( int i = 0; i < array.Length; i++){
//     array[i] *= -1;
// }

// Console.WriteLine($"[{String.Join ("," , array)}]");

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


// Задача 3 

// int[] array = GetArray(10, 1, 100);
// Console.WriteLine($"[{String.Join ("," , array)}]");
// Console.WriteLine($"Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (findElement(array, num))
// {
//     Console.WriteLine($"Данный элемент в массиве есть");
// }
// else 
// {
//     Console.WriteLine($"Данный элемент в массиве нет");
// }

// // ----------Метод------------

// bool findElement(int[] array, int num)
// {
//     foreach (int el in array)
//     {
//         if (el == num)
//         {
//             return true;
//         }
        
//     } return false; 
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


// Задача 4

// int[] array = GetArray(123, 0, 1000);
// Console.WriteLine($"[{String.Join ("," , array)}]");

// Console.WriteLine($"{countEl(array)}");

// // -------------Метод-------------

// int countEl(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el >= 10 && el <= 99)
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


// Работа на семинаре 6

// Задача 1 

// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] resultArray = ReverseArray2(array);
// Console.WriteLine($"[{String.Join(",", resultArray)}]");

// ReverseArray1(array);
// Console.WriteLine($"[{String.Join(",", array)}]");

// // ----------Методы---------------
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReverseArray1(int[] array){
//     for(int i = 0; i < array.Length/2; i++){
//         int k = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = k;
//     }
// }

// int[] ReverseArray2(int[] array){
//     int[] result = new int[array.Length];
//     for(int i = 0; i < array.Length; i++){
//         result[i] = array[array.Length - i - 1];
//     }
//     return result;
// }


// Задача 2 

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);

// if( findElement(a, b, c)){
//     Console.WriteLine("Такой треугольник существует.");
// }
// else {
//     Console.WriteLine("Такой треугольник не существует.");
// }
// //--------метод-----------
// bool findElement(int a, int b, int c){
//     if(a < b + c && b < a + c && c < a + b){
//         return true;
//     }
//     return false;
// }


// Задача 3 
//Определить, является ли заданное шестизначное число счастливым. 
//(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр)

// void HappyNumber(int number){
//     string num = Convert.ToString(number);
//     int resOne = 0;
//     int resTwo = 0;
//     int[] numArray = new int[num.Length];
//     for(int i = 0; i < num.Length; i++){
//         numArray[i] = num[i];
//     }
//     int j = numArray.Length - 1;
//     for(int i = 0; i < num.Length / 2; i++){
//         resOne += Convert.ToInt32(numArray[i]);
//         resTwo += Convert.ToInt32(numArray[j]);
//         j--;
//     }
//     if(resOne == resTwo){
//         Console.WriteLine($"Число {number} счастливое");
//     }
//     else{
//         Console.WriteLine($"Число {number} НЕсчастливое");
//     }
// }

// int number = 123123;
// HappyNumber(number);


// Задача 4 

// void Fibonachi(int N){
//     int firstnum = 0;
//     int secondnum = 1;
//     Console.Write($"{firstnum} ");
//     Console.Write($"{secondnum} ");
//     int summ = firstnum + secondnum;
//    for(int i = 2; i < N; i++){
//     Console.Write($"{firstnum + secondnum} ");
//     firstnum = secondnum;
//     secondnum = summ;
//     summ = firstnum + secondnum;
//    }
// }

// Fibonachi(15);