/* Задача 1: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// string Recurs(int minValue, int n)
// {
//     if(minValue == n)
//     {
//         return n.ToString();
//     }
//     return (minValue + " " + Recurs(minValue + 1, n));
// } 

// Console.WriteLine(Recurs(1, n)); 

/* Задача 2: числа от m до n. */

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

string Recurs(int m, int n)
{
    if(m == n)
    {
        return n.ToString();
    }
    return (m + " " + Recurs(m + 1, n));
} 

Console.WriteLine(Recurs(m, n)); 