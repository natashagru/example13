// программа которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine("введите любое число");
int a = int.Parse(Console.ReadLine()!);
int b = a;
while (a > 999 || a < -999)
    {
        a = a / 10;         
    }
if (a < 0)
    {
        a = -a;
    }
if (a < 999 && a > 99)
{
    Console.WriteLine($" третья цифра числа { b } -> { a % 10 } ");
}
else
{
    Console.WriteLine($" число {b} состоит меньше, чем из трех цифр");
}