/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/
int Tdig (int num)
{
    int ed= num/ 10;
    num=ed;
    num= num% 10;
    return num;
}
Console.Write("Input 3digit number: ");
string b=Console.ReadLine();
if(b.Length!=3)
{
    Console.WriteLine("Error! Input 3digit number!!!");
}
else{
int user_num = Convert.ToInt32(b);
int res= Tdig(user_num);
Console.WriteLine(res);
}
/*Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
int Tdig (int num)
{
 while(num>999)
 {
    num=num/10;
 }
 num=num %10;
 return num;
}
Console.Write("Input 3digit number: ");
int b=Convert.ToInt32(Console.ReadLine());
if(b<=99)
{
    Console.WriteLine("there is no third digit");
}
else{
int res=Tdig(b);
Console.WriteLine(res);
}
/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/
int today(int num)
{
    int a;
    if(num<=5)
    {
         a=1;
    }
    else{
       a=2;
    }
    return a;
}
Console.Write("Input your week number: ");
int b=Convert.ToInt32(Console.ReadLine());
if(b>=8)
{
    Console.WriteLine("Error!There are only 7 days in a week!");
}
else
{
    int result=today(b);
    if(result==1)
    {
        Console.WriteLine("today is a weekday");
    }
    else{
        Console.WriteLine("today is a today is a day off");
    }
}