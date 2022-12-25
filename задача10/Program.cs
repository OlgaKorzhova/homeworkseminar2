//  Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("Введите число" );
int n = int.Parse(Console.ReadLine());

if(n > 99)
{
    Console.WriteLine((n/10)%10);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}