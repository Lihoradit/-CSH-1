/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
int[] mas(int index)
{
    int[] mas = new int[index];
    Console.Write("Your array:[");
    for (int i = 0; i < index; i++)
    {
        mas[i] = new Random().Next(100, 999);
        Console.Write(mas[i]);
        if(i+1<index) Console.Write(",");
    }
    Console.WriteLine("]");
    return mas;
}
void sum(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 != 1)
        {
            result++;
        }
    }
    Console.WriteLine("Sum of positive number array:" + result);
}
Console.Write("Input array lenght: ");
int gg = Convert.ToInt32(Console.ReadLine());
sum(mas(gg));
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
int[] array(int ind)
{
    int[] array=new int[ind];
    Console.Write("Your array:[");
    for(int i=0; i<ind; i++)
    {
        array[i]=new Random().Next(1,9);//Задал небольшие рамки, 
        //ибо рандомило большие числа, 
        //которые я не мог в голове посчитать, что бы код проверить тт~тт
         Console.Write(array[i]);
        if(i+1<ind) Console.Write(",");
    }
    Console.WriteLine("]");
    return array;
}void sum1(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length;i++)
    {
        if(i%2==1)
        {
            sum+=array[i];
        }
    }
    Console.WriteLine("The sum of array elements on odd index values: "+sum);
}
Console.Write("Input array size:");
int ggg=Convert.ToInt32(Console.ReadLine());
sum1(array(ggg));
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/
double[] mass(int indx,int n, int m)
{
    double[] mass=new double[indx];
    Console.Write("Your array:[");
    for(int i=0;i<indx;i++)
    {
        mass[i]=new Random().Next(n,m+1)+new Random().NextDouble();
        Math.Round(mass[i],2);//У меня он почему то отказывается работать...
        Console.Write(mass[i]);
        if(i+1<indx) Console.Write(",");
    }
    Console.WriteLine("]");
    return mass;
}
void summ(double[]mass)
{
    double resultt=0;
    double minValue=mass[0];
    double maxValue=0;
    for(int i=0; i<mass.Length;i++)
    {
        if(mass[i]>maxValue)
        {
            maxValue=mass[i];
        }
        else if(mass[i]<minValue)
        {
            minValue=mass[i];
        }
    }
    resultt=maxValue-minValue;
    Console.WriteLine("The difference between the maximum and minimum value:"+resultt);
}
Console.WriteLine("Input array size:");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array minValue:");
int minv=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input array maxValue:");
int maxv=Convert.ToInt32(Console.ReadLine());
summ(mass(size,minv,maxv));