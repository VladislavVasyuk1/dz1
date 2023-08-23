/* Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Proverka(int m)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
{
        Console.Write("Input the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if ( num > 0) temp++;
}
return temp;
}
Console.Write("input the amount of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proverka(m));
*/

/*ask 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void line(double b1,double k1,double b2,double k2)
{
if (k1 == k2)
    {
    if (b1 == b2)
        Console.WriteLine("Совпадают!");
    else
        Console.WriteLine("Параллельны!");
    }
else
{
    double x = (b2- b1) / (k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine(x + ", " + y);
}
}

Console.Write("input the b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input the k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input the b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input the k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

line(b1, k1, b2, k2);
/7


