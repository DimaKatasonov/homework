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