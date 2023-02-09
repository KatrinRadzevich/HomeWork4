// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] randomArray = new int[8];
randomArray = GenerateArray();
PrintArray(randomArray);
int[] GenerateArray()
{
    int[] randomArray = new int[8];
    for (int count = 0; count <= 7; count++) randomArray[count] = new Random().Next(0, 35);
    return randomArray;
}
void PrintArray(int[] randomArray)
{
    for (int count = 0; count <= (randomArray.Length - 2); count++)
        Console.Write($"{randomArray[count]}, ");
    Console.Write($"{randomArray[randomArray.Length - 1]} -> ");
    Console.Write("[");
    for (int count = 0; count <= (randomArray.Length - 2); count++)
        Console.Write($"{randomArray[count]}, ");
    Console.Write($"{randomArray[randomArray.Length - 1]}]");
}