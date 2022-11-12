//Задача №2 Напишите программу, которая на вход 
//принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число число:");
int N1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число:");
int N2=Convert.ToInt32(Console.ReadLine());
if(N1>N2)
{
    Console.WriteLine($"{N1} больше, чем {N2}");
}
else
{
    Console.WriteLine($"{N2} больше, чем {N1}");
}