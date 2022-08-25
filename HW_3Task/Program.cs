//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()); 
int i = 1; 
while (n > 0 && i <= n)
{
Console.WriteLine("{0} в кубе равно 1{1}", i, Math.Pow(i, 3));
 i++;   
}
Console.WriteLine();

while (n < 0 && i >= n)
{
Console.WriteLine("{0} в кубе равно {1}", i, Math.Pow(i, 3));
 i--;   
}
Console.WriteLine();