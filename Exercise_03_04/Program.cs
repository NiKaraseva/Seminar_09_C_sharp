/* Задача 3: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9 */ 


// Console.WriteLine("Введите число: ");
// int m = int.Parse(Console.ReadLine()!);

// int SumRecur(int x)
// {
//     if(x == 0) 
//     {
//         return 0;
//     }
//     return(x % 10 + SumRecur(x / 10));
// } 

// Console.WriteLine(SumRecur(m));


/* Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень числа b: ");
int b = int.Parse(Console.ReadLine()!);

int PowRecur(int x, int y)
{
    if(y == 0)
    {
        return 1;
    }
    if(y == 1)
    {
        return x;
    }
    return(PowRecur(x, y - 1) * x);
}
Console.WriteLine();
Console.WriteLine(PowRecur(a, b));