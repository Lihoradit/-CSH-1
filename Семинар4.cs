/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.*/
int degree(int args1, int args2)
{
    int result = 1;
    for (int c = 1; c <= args2; c++)
    {
        result *= args1;
    }
    return result;

}

Console.WriteLine("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 < 0)
{
    Console.WriteLine("This program does not know how to raise to a negative degree");
}
else
{
    int ret = degree(num1,num2);
    Console.WriteLine($"{num1} to the degreed of {num2} will be: {ret}");
}
/*Задача 27: Напишите программу,
которая принимает на вход число и выдаёт сумму цифр в числе.*/
void sum(int num)
{
    int result = 0;
    for (int c = num; c > 0; c--)//Одному богу известно(и то врядли уже), как это работает
    //по моим подсчетам получается следующее: я ввожу допустим 118(1+1+8=10, все работает корректно), но
    //если зенками поглазеть на код то должно быть так: c=118
    //118>0, выполняется цикл(остаток от деления на 10 записывается в result), потом 
    //118 делиться на 10, остается 11,8(но т.к. тип переменной int, то 0,8 откисает)
    //и c-- должен получается где то в этой схеме вычитать единичку проклятую,
    //но где он это делает я не понимаю, ибо должен быть ответ тогда не верным, если из тех же
    //11,8 он вычтет 1 то будет 11,8-1=10,8 и тогда ответ в корне другой будет, от того не правильный
    //но почему то все работает... 
    {
        int a1 = num % 10;
        result += a1;
        num=num/10;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
sum(number);
/*Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.*/
int[] mas(int h, int k, int size)
{
    int[] array= new int[size];
    for(int i=0; i<size; i++){
    array[i]=new Random().Next(h,k);
    }
    return array;
}
void ShowArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
Console.WriteLine("Enter the started array boundaries:");
int p=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the ended array boundaries:");
int l=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the array size:");
int size=Convert.ToInt32(Console.ReadLine());
int[] array1= mas(p,l,size);
ShowArray(array1);



