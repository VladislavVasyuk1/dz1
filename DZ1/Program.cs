/* task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int chislo2 = Convert.ToInt32(Console.ReadLine());

if (chislo1 > chislo2)
    Console.WriteLine("max = " + chislo1 + "\nmin = " + chislo2);

else
    Console.WriteLine("max = " + chislo2 + "\nmin = " + chislo1);
*/

/* task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int chislo2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int chislo3 = Convert.ToInt32(Console.ReadLine());

if (chislo1 > chislo2)
    if (chislo1 > chislo3)
        Console.WriteLine(chislo1 + " самое большое!");

    else
        Console.WriteLine(chislo3 + " самое большое!");

else
    if (chislo2 > chislo3)
        Console.WriteLine(chislo2 + " самое большое!");

    else
        Console.WriteLine(chislo3 + " самое большое!");
*/

/* task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число для проверки на чётность: ");
int num = Convert.ToInt32(Console.ReadLine());

int del = num % 2;

if (del == 0)
{ 
    if (num == 0)
    {
        Console.WriteLine("Your namber 0");
    }
    else
    {
        Console.WriteLine("Yes");
    }
}
else
{ 
    Console.WriteLine("No");
}
*/

/* task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Input namber: ");
int num = Convert.ToInt32(Console.ReadLine());
int count =1;

while (count <= num) {
    int del = count % 2;
    if (del == 0)
    {
        Console.Write(count + ", ");
        count++ ; 
    }
    else
    {
        count++ ;
    }
    }
*/
// OR
/* The second version of the 8 task.

Console.Write("Input namber: ");
int num = Convert.ToInt32(Console.ReadLine());
int count =2;

while(count <= num)
{
    Console.Write(count + ", ");
    count = count + 2 ; 
}
*/