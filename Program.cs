// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵);   2, 4 -> 16 

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Введите число степень: ");
// int b = Convert.ToInt16(Console.ReadLine());
        
//         int result = 1;
//         for (int i = 1; i <= b; i++)
//         {
//             result *= a;
//         }
        
//         Console.WriteLine("Результат: " + result);
// _____________________________________________________________________________________________

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt16(Console.ReadLine());
// int len = Length(a);
// Console.Write($"{Sum(a,len)}");
// int Length(int a)
// {
//     int ind = 0;
//         while (a > 0)
//         {
//             a /= 10;
//             ind++;
//         }
//     return ind;
// }
// int Sum(int a, int len)
//     {
//         int sum = 0;
//         for (int i = 1; i <= len; i++)
//     {
//             sum += a % 10;
//             a /= 10;
//     }
// return sum;
// }
// _____________________________________________________________________________________

// Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt16(Console.ReadLine());
// int[] randomArray =new int[a];
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(1,99);
// Console.Write(randomArray[i] + " " );
// }