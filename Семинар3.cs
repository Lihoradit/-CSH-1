/*Задача 19
Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли оно палиндромом.*/
/*void pal(int pal)
{
    int a1,b1;
    if(pal<=99999 && pal>=10000)
    {
        a1=pal%100;
        b1=pal/1000;
        if(a1%10==b1/10 && b1%10==a1/10)
        {
        Console.WriteLine("yeep");
        }
        else{
            Console.WriteLine("nooo((((((");
        }
    }
    else{
        Console.WriteLine("5d number idiot!.");
    }
}
Console.WriteLine("Send your 5d number");
int a=Convert.ToInt32(Console.ReadLine());
pal(a);*/
/*Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.*/
/*double AMOGUS(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double a = Math.Round(
    Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) +
   (z2 - z1) * (z2 - z1)), 2);
    return a;
}
Console.WriteLine("Send A point(x,y,z) coordinates");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Send B ponint(x,y,z) coordinates");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());
double g = AMOGUS(xa, ya, za, xb, yb, zb);
Console.WriteLine(g);*/
/*Задача 23
Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
/*void abdurozik(int a)
{
    int current = 1;
    int b;
    while (current <= a)
    {
        b = current * current * current;
        Console.Write($" {b},");
        current++;

    }

}
Console.WriteLine("Инпут ёр намбер: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1)
{
    Console.Write(num + "->");
    abdurozik(num);
}
else
{
    Console.WriteLine("Инкорректед нумбер");
}
*/