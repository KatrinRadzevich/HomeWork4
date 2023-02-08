// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//3⁵ {a}{ᵇ} эта часть здесь выглядит как надо,а в консоле не вышло
//пыталась по-разному,буду благодарна,если подскажете,как это правильно делать)
// char symbol = 'B';
// Console.WriteLine(char.GetUnicodeCategory(symbol));
//а после этого варианта в консоли пишет UppercaseLetter

//старый способ
// Console.WriteLine("Введите 2 разных числа(А и В),чтобы увидеть число А в натуральной степени числа В");
// Console.WriteLine("Введите число А: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int b = int.Parse(Console.ReadLine());
// if (a <= 0 || b <= 0)
// {
//     Console.WriteLine("Оба числа должны быть положительными,попробуйте снова");
// }
// else if (a > 0 && b > 0)
// {
//     Console.WriteLine($"{a}, {b} -> {Math.Pow(a, b)}");
// }

//новый способ
Console.WriteLine("Введите 2 разных числа(А и В),чтобы увидеть число А в натуральной степени числа В");
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}, {b} -> {GetSomePow(a)}");
if (a <= 0 || b <= 0)
{
    Console.WriteLine("Оба числа должны быть положительными,попробуйте снова");
}
double GetSomePow(double AB)
{
    for (int i = 0; i < b; i++)
    {
        AB = Math.Pow(a, b);
    }
    return AB;
}
