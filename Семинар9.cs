/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/
/*void ShowNum(int val)
{
    Console.Write(val);
    if(val!=1) Console.Write(",");
    if (val > 1)
    {
        val -= 1;
        ShowNum(val);
    }
}
Console.WriteLine("Enter a value: ");
int userNum = Convert.ToInt32(Console.ReadLine());
ShowNum(userNum);*/
/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
/*void SumNumber (int num1, int num2)
{
    int tab=num1;
    int result=num1;
    while(tab<num2)
    {
        tab++;
        num1++;
        result+=num1;
    } 
    Console.WriteLine(result);
}
Console.WriteLine("Enter a value1: ");
int userNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value2: ");
int userNum2 = Convert.ToInt32(Console.ReadLine());
SumNumber(userNum1, userNum2);*/
/*Задача 68: дополнительно
Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.*/
string result = string.Empty;
string BinaryConvert(int value)
{
    if (value >= 1)
    {
        int j = value % 2;
        result += $"{j}";
        value /= 2;
        BinaryConvert(value);
    }

    return result;
}
void ShowNum(string res)
{
    for (int i = res.Length; i > 0; i--)
    {
        Console.Write(res[i-1]);
    }
}
Console.WriteLine("Enter a value: ");
int userNum3 = Convert.ToInt32(Console.ReadLine());
ShowNum(
        BinaryConvert(userNum3));