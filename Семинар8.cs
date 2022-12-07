/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.*/
int[,] Fillarray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < column; k++)
        {
            array[i, k] = new Random().Next(1, 10 + 1);
        }
    }
    return array;
}
int[,] Sortarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] > array[i, z + 1])
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
    return array;
}
void Showarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i, k] + " ");
        }
        Console.WriteLine();
    }
}
int MinSumArray(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sum[i] += array[i, k];
        }
    }
    int temp = sum[0];
    int result=0;
    for (int k = 0; k < sum.Length; k++)
    {
        if (sum[k] < temp)
        {
            temp = sum[k];
            result=k+1;
        }
    }
    return result;
}
Console.WriteLine("Enter the columns number:");
int userColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the row number:");
int userRow = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[userRow, userColumn];
array = Fillarray(userRow, userColumn);
Showarray(array);
Sortarray(array);
Console.WriteLine();
Showarray(array);
/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
int res = MinSumArray(array);
Console.WriteLine($"The row with the smallest sum of numbers: {res}");
/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
matrix1 = Fillarray(matrix1.GetLength(0), matrix1.GetLength(1));
matrix2 = Fillarray(matrix2.GetLength(0), matrix2.GetLength(1));
Showarray(matrix1);
Console.WriteLine();
Showarray(matrix2);
Arrayx(matrix1, matrix2);
void Arrayx(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            result[i, k] = array1[i, k] * array2[i, k];
        }
    }
    Showarray(result);
}
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
int[,,] FillNewArray()
{
    int[,,] matrix = new int[2, 2, 2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                matrix[i, k, j] = new Random().Next(0, 100 + 1);
            }
        }
        
    }
    return matrix;
}
void ShowNewArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
         for (int j = 0; j < array.GetLength(2); j++)
         {
            Console.WriteLine($"{array[i,k,j]}({i},{k},{j})");
         }   
         Console.WriteLine();
        }
    }
}
Console.WriteLine("=)");
int[,,] roflmatrix=new int[2,2,2];
roflmatrix=FillNewArray();
ShowNewArray(roflmatrix);
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] WeeWeeMatrix()
{
    int n = 4;
    int[,] weeWee = new int[n, n];

    int temp = 1;
    int i = 0;
    int k = 0;

    while (temp <= weeWee.GetLength(0) * weeWee.GetLength(1))
    {
        weeWee[i, k] = temp;
        temp++;
        if (i <= k + 1 && i + k < weeWee.GetLength(1) - 1)
            k++;
        else if (i < k && i + k >= weeWee.GetLength(0) - 1)
            i++;
        else if (i >= k && i + k > weeWee.GetLength(1) - 1)
            k--;
        else
            i--;
    }
    return weeWee;
}
int[,] weeMatrix=new int[4,4];
weeMatrix=WeeWeeMatrix();
Showarray(weeMatrix);