/* task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size )
{
    int[] array = new int[size];  //величина и инициализация массива

    for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
    return array;
}

void WriteArray(int[] array)  // вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int parity(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            count++;
        }
    return count;
}

Console.Write("Inpun a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
WriteArray(myArray);

Console.WriteLine(parity(myArray));
*/

/* task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size )
{
    int[] array = new int[size];  //величина и инициализация массива

    for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(-1000, 1000);
        }
    return array;
}

void WriteArray(int[] array)  // вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int oddEl(int[] array)  
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Inpun a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
WriteArray(myArray);
Console.WriteLine(oddEl(myArray));
*/

/* task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size )
{
    double[] array = new double[size];  //величина и инициализация массива

    for(int i = 0; i < size; i++)
        {
            Console.Write("Input the number in the array: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    return array;
}

void WriteArray(double[] array)  // вывод массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double minMax(double[] array)
{
    double res = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        else if(min > array[i]) min = array[i];
    }
    res = max - min;
    return res;
}

Console.Write("Inpun a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length);
WriteArray(myArray);


Console.WriteLine(minMax(myArray));
*/

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
