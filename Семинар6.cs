/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
/*Console.WriteLine ("Input number after ',':");
string numbers = Console.ReadLine();
string [] newNumbers = new string [numbers.Length];
double k = 0;
for (double i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
  }
}
k++;
double [] resultNumbers = new double[k];
PrintArray (resultNumbers, newNumbers);
double sum = 0;
for (double i = 0; i < k; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Positive numbers: "+sum);

void PrintArray (double [] array, string [] string1)
{
  for (double i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}*/
/*Задача 43: Напишите программу,
 которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/
void func(double x1, double y1, double x2, double y2)
{
    double x = (y2 - y1) / (x1 - x2);
    double y = x1 * x + y1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"intersection at a point: ({x};{y})");
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
func(x1, y1, x2, y2);