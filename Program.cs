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




