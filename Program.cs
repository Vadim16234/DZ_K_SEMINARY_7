// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// РЕШЕНИЕ

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);


// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write(" {0:F1} ", (Array[i,j]));
//         }
//         Console.WriteLine();
//     }
// }



// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// РЕШЕНИЕ

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите координаты в строках: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координаты в столбцах: ");
// int b = int.Parse(Console.ReadLine()!);


// for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++){
//         if (a == i && b == j){
//             Console.WriteLine($"Значение заданного элемента = {array[i,j]}");
//         }
//         if (a > array.GetLength(0) || b > array.GetLength(1) ){
//             Console.WriteLine("такого числа нет!!!");
//         }
//     }
// }







