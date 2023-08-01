// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



/* Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Range(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double z = z1 - z2;
    double QuartResul = x*x + y*y + z*z;
    return Math.Round(Math.Sqrt(QuartResul), 2);
}

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(x1,x2,y1,y2,z1,z2));
*/
/* Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Quart( int arg1)
{
    int count = 1;
        if (arg1 > 0)
            while (count <= arg1)
                {
                Console.WriteLine($"{count} - {Math.Pow(count, 3)}");
                count++;
                }
}
Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Quart(num);
*/