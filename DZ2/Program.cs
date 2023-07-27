/* Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecNum(int arg)
{
int numHungrets = arg / 10;
int res = numHungrets % 10;
return res;
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int resultat = SecNum(number);

Console.WriteLine("The second number " + resultat);
*/

/* Task 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).

int ThreeNum (int arg1)
{
if (arg1 / 100 == 0)
{
int res1 = -1;
return res1;
}
while (arg1 / 1000 != 0)
{
arg1 = arg1 / 10;
}
int res2 = arg1 % 10;
return res2;
}

Console.Write("Input the number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int resul = ThreeNum(num1);

Console.WriteLine("The third digit from the given number " + num1 + " is " + resul);
*/

/* Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

bool weekday (int arg1)
{
return arg1 == 6 || arg1 == 7 ;
}

Console.Write("Input weekday: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool resul = weekday(num1);

if (resul)
Console.WriteLine("Yes");
else
Console.WriteLine("No");
*/