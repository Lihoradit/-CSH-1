double[,] FillMatrix(int row, int column)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < column; k++)
        {
            matrix[i, k] = new Random().Next(1, 10 + 1);
            double a = new Random().NextDouble();
            matrix[i, k] += a;
            matrix[i, k] = Math.Round(matrix[i, k], 1);
        }
    }
    return matrix;
}
void ShowMatrix(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write(matrix[i, k] + " ");
        }
        Console.WriteLine();
    }
}
void FindNumber(double[,] matrix, int rowFind, int columnFind)
{
    if (rowFind < matrix.GetLength(0) && columnFind < matrix.GetLength(1))
        Console.WriteLine(matrix[rowFind, columnFind]);
    else
    {
        Console.WriteLine("The array does not have such a position");
    }
}
double[,] ConvertMatrix(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i,k]= Math.Round(matrix[i,k],0);
        }
    }
    return matrix;
}
void ArithmeticMean(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result=0;
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            result+=matrix[k,i];
        }
        result=result/matrix.GetLength(1);
        result=Math.Round(result,1);
        Console.WriteLine($"Arithmetic mean {i+1} column={result}");
    }
}
/*Задача 47. Задайте двумерный массив 
размером m×n, заполненный случайными вещественными числами.*/
Console.WriteLine("Enter the columns number:");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the rows number: ");
int row = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[row, column];
matrix = FillMatrix(row, column);
ShowMatrix(matrix);
Console.WriteLine();

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.*/
Console.WriteLine("Enter the column number:");
int columnFind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the row number: ");
int rowFind = Convert.ToInt32(Console.ReadLine());
FindNumber(matrix, rowFind, columnFind);
/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
ConvertMatrix(matrix);
ShowMatrix(matrix);
ArithmeticMean(matrix);
