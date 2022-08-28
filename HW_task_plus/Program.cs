/*Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
необходимо вывести максимальную цифру в полученном округлённом значении площади круга
10 -> 4
20 -> 7
30 -> 8*/

Console.Clear();
Console.WriteLine("Введите радиус круга: ");
Console.Write("r = ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Найдите площадь круга.");
double S = Math.PI * Math.Pow(r, 2); 
double S1 = Math.Round(S, 0, MidpointRounding.AwayFromZero);
Console.WriteLine($"Площадь круга, округленная до целого числа, равна {S1}.");
string str = S1.ToString();
int max = int.Parse(str[0].ToString());
for (int i = 1; i < str.Length; i++)
{
    if (int.Parse(str[i].ToString()) > max)
        max = int.Parse(str[i].ToString());
}
Console.Write("Максимальная цифра в полученном округлённом значении площади круга равна ");
Console.WriteLine(max);
