// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] inputAvtoArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i,j]=new Random().Next(0,10);
//       Console.Write(array[i, j] + "  ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }

// int[,] outputAvtoArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//          Console.Write(array[i, j] + "  ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }

// int [,] sort(int[,] array)
// { 
// for (int m=0; m<array.GetLength(0); m++)
// {
// int j=0;
// int min=array[m,0];
// int indexMin=0;

// while (j<array.GetLength(1))
// {
// for (int i = 0; i < array.GetLength(1)-j; i++)
// {

// if (min>array[m,i])
//    {
//     min=array[m,i];
//     indexMin=i;
//    }
// }
// int temp= array[m,array.GetLength(1)-j-1];
// array[m,array.GetLength(1)-j-1]=min;
// array[m,indexMin]=temp;
// min=array[m,0];
// indexMin=0;
// j++;

// }

// }
// return array;
// }


// Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] array =new int [rows, colums];
// inputAvtoArray(array);
// Console.WriteLine();


// sort(array);
// outputAvtoArray(array);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] inputAvtoArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i,j]=new Random().Next(0,10);
//       Console.Write(array[i, j] + "  ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }

// Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array =new int [rows, rows];
// int[] array2=new int [rows];
// inputAvtoArray(array);
// Console.WriteLine();
// int sum=0;
//  for (int i = 0; i < array.GetLength(0); i++)
// {  
//   sum=0;
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     sum=sum+array[i,j];
//   }
//   array2[i]=sum;
// }
//  Console.WriteLine(String.Join(" ",array2));

// int min=array2[0];
// int indexMin=0;
// for (int i = 0; i < array2.Length; i++)
// {
//   if (array2[i]<=min)
//   {
//     min=array2[i];
//     indexMin=i;
//   }
// }
//  Console.WriteLine("номер строки с наименьшей суммой элементов: "+(++indexMin)+" строка");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18


//  int[,] inputAvtoArray(int rows,int colums)
// {
//   int[,] array =new int [rows, colums];
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i,j]=new Random().Next(0,10);
//       // Console.Write(array[i, j] + "  ");
//     }
//     // Console.WriteLine();
//   }
//   return array;
// }

// void outputAvtoArray(int[,] array)
// {
//   Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//          Console.Write(array[i, j] + "  ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

//  Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] array1=inputAvtoArray(rows,colums);

//  Console.WriteLine("Введите количество столбцов");
// rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// colums = Convert.ToInt32(Console.ReadLine());

// int[,] array2=inputAvtoArray(rows,colums);


// outputAvtoArray(array1);
// outputAvtoArray(array2);

// int [,]multiplicationArray(int [,]array1, int [,]array2)
// {
// int[,] array3= new int[array1.GetLength(0),array2.GetLength(1)];
// for (int i = 0; i < array1.GetLength(0); i++)
// {
//   for (int j = 0; j < array2.GetLength(1); j++)
//   {
//     array3[i,j]=0;
//     for (int n = 0; n<array1.GetLength(1); n++)
//     {
//       array3[i,j]=array3[i,j]+array1[i,n]*array2[n,j];
//     }
//   }
// }
// return array3;
// }

// if (array1.GetLength(1) == array2.GetLength(0))
// {
// int [,]array3=multiplicationArray(array1,array2);
// Console.WriteLine("Результирующая матрица будет:");
// outputAvtoArray(array3);
// }
// else
// {
// Console.WriteLine("Матрицы можно перемножать друг на друга, только если количество столбцов в первой матрице, равно количеству строк второй. Умножение не возможно.");
// }
// Console.WriteLine();


//  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] inputAvtoArray(int rows, int colums, int osZ)
// {
//   int[,,] array = new int[rows, colums, osZ];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int z = 0; z < array.GetLength(2); z++)
//       {
//         int num = new Random().Next(10,100);
//         for (int a = 0; a < array.GetLength(0); a++)
//         {
//           for (int b = 0; b < array.GetLength(1); b++)
//           {
//             for (int c = 0; c < array.GetLength(2); c++)
//             {
//               // array[0,0,0]=num+1;
//               if (array[a, b, c] == num)
//               {
//                 num = new Random().Next(10,100);
//                 a = 0;
//               }
//             }
//           }
//         }
//         array[i,j,z]=num;
//       }
//     }

//   }
//   return array;
// }

// void outputAvtoArray(int[,,] array)
// {
//   Console.WriteLine();
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int z = 0; z < array.GetLength(2); z++)
//       {
//         Console.Write(array[i, j, z] + " " + (i, j, z) + "  ");
//       }
//       Console.WriteLine();
//     }


//     // Console.WriteLine();
//   }
//   Console.WriteLine();
// }



// Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличемтво по оси Z");
// int osZ = Convert.ToInt32(Console.ReadLine());
// int[,,] array = inputAvtoArray(rows, colums, osZ);
// outputAvtoArray(array);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void outputAvtoArray(int[,] array)
{
  Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      {
        if (array[i,j]<10)
        {
          Console.Write ("0"+array[i,j]+" ");
        }
        else
        {
        Console.Write (array[i,j]+" ");
        }
      }
      
    }
    Console.WriteLine();
  }
}


Console.WriteLine("Введите количество столбцов");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int colums = Convert.ToInt32(Console.ReadLine());
int numElement=rows*colums;
int [,]array= new int[rows,colums];
int g=0;
int a=0;
while (g<numElement)
{
  
for (int j = a; j < array.GetLength(1)-a; j++)
{
  if (g==numElement) break;
  array[a,j]=++g;
     
}

for (int i = 1+a; i < array.GetLength(0)-a; i++)
{
  if (g==numElement) break;
  array[i,array.GetLength(1)-1-a]=++g;
  
}

for (int j = array.GetLength(1)-2-a; j >=a; j--)
{
  if (g==numElement) break;
  array[array.GetLength(0)-1-a,j]=++g;
  
}

for (int i = array.GetLength(0)-2-a; i >=1+a; i--)
{
  if (g==numElement) break;
  array[i,a]=++g;
  
}
  
  a=a+1;
  }
outputAvtoArray(array);




