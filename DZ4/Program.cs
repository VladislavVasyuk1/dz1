/* Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int quart(int num, int ct)
{
    int res = 1;
    for(int i = 0; i < ct; i++)
        res *= num;
return res; 
}

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the degree: ");
int ct = Convert.ToInt32(Console.ReadLine());

Console.Write(quart(num, ct));
*/

/* Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumNumber(int num)
{
    int sum = 0;
    while (num != 0)
       {
        sum += num % 10;
        num = num / 10;
       }
    return sum;
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(sumNumber(number));
*/

/* Task 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int [] myArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input the number in the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void vArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
}

Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = myArray(size);
vArray(newArray);
*/