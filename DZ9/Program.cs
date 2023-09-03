/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void creatNum(int num)
{
    if (num == 1)
        Console.WriteLine(num);
    else
    {
        Console.Write(num + ", ");
        num--;
        creatNum(num);
    }
}

Console.WriteLine("Input the number: ");
int Num = Convert.ToInt32(Console.ReadLine());
creatNum(Num);
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void sum(int m, int n)
{ 
    if (m == n && m > 0)
        Console.WriteLine(m); 
    else
    {
        if (m <= 0) m++;
        else 
        {
            Console.Write(m + ", ");
            m++;
            
        }
       sum(m, n); 
    }
    
}
Console.WriteLine("Input the number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number: ");
int n = Convert.ToInt32(Console.ReadLine());
sum(m,n);
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
*/