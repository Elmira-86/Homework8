//Домашнее задание 1

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
// {                                                                           
//   int[,] newArray = new int[rows, columns];  

//   for (int i = 0; i < rows; i++)
//   {
//      for(int j = 0; j < columns; j++)
//      {
//        newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//      }
//   }
//   return newArray;    
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0;i < array.GetLength(0) ;i++ ) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)  
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine(); 
//     }
// }
// int[,] DecreasingRows (int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m,n,min,max);

// Show2DArray(myArray);
// DecreasingRows(myArray);
// Console.WriteLine();
// Show2DArray(myArray);

// Домашнее задание 2 

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Random2DArray(int [,] newArray)  
// {                                                                           
//   for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             Console.Write($"{newArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }    
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// }
// int[,] MinElRows (int[,] array)
// {
//    {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }
//     return array;
// }

// int[,] myarray = new int[4, 4];
// Show2DArray(myarray);
// Random2DArray(myarray);
// Console.WriteLine();
// MinElRows(myarray);
// Console.WriteLine();

// Домашнее задание 3 

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел от 1: ");

// void MultiMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secondMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// void CreateMatrix(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void ShowArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] firstMartrix = new int[m, n];
// CreateMatrix(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// ShowArray(firstMartrix);

// int[,] secondMartrix = new int[n, p];
// CreateMatrix(secondMartrix);
// Console.WriteLine($"Вторая матрица:");
// ShowArray(secondMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiMatrix(firstMartrix, secondMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// ShowArray(resultMatrix);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }
        
// Домашнее задание 4

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = InputNumbers("Введите значение x: ");
// int y = InputNumbers("Введите значение y: ");
// int c = InputNumbers("Введите значение c: ");
// Console.WriteLine($"");

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void Show3DArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//         for (int k = 0; k < array3D.GetLength(2); k++)
//         {
//         Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}) ");
//         }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void three3DArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int c = 0; c < array3D.GetLength(2); c++)
//       {
//         array3D[x, y, c] = temp[count];
//         count++;
//       }
//     }
//   }
// }

// int[,,] array3D = new int[x, y, c];
// three3DArray(array3D);
// Show3DArray(array3D);
// Console.WriteLine();

// Домашнее задание 5

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// Show3DArray(nums);

// void Show3DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

