// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// программа работает для любого положительного числа от двухзначного,до семизначного 
Console.Write("Введите число,чтобы узнать сумму его цифр: ");
int x = int.Parse(Console.ReadLine());
if (x <= 9)
{
    Console.WriteLine("Число должно быть положительным и состоять из 2 или более цифр");
}
else if (x > 10000000)
{
    Console.WriteLine("Число должно состоять не более чем из 7 цифр");
}
else
{
    Console.Write($"{x} -> ");
    int sum = 0;
    for (int i = 6; i >= 0; i--)
    {
        sum += x / (int)Math.Pow(10.0, i);
        x = x % (int)Math.Pow(10.0, i);
    }
    Console.Write(sum);
}