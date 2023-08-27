/* Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRanddom()
{
    Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            {
                array[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
            }
    }
    return array; 
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}

double[,] myArray = CreateRanddom();
Show2dArray(myArray);
*/

/* Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRanddom()
{
    Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            {
                array[i, j] = new Random().Next(min, max+1);
            }
    }
    return array; 
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}

void poisk(int[,] array)
{
    Console.WriteLine("Input the x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x < array.GetLength(0) || y < array.GetLength(1))
        Console.WriteLine(array[x,y]);
    else Console.WriteLine("The " + x +", " + y + " element does not exist");
}

int[,] myArray = CreateRanddom();
Show2dArray(myArray);
poisk(myArray);
*/

/* Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

double[,] CreateRanddom()
{
    Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            {
                array[i, j] = new Random().Next(min, max+1);
            }
    }
    return array; 
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}

double[] res(double[,] array)
{   
    
    double[] massiv = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
        for(int x = 0; x < array.GetLength(0); x++)
            massiv[i] += Convert.ToDouble(array[x, i] / (array.GetLength(1)));
    return massiv;
}

void WriteArray(double[] array)  
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double[,] myArray = CreateRanddom();
Show2dArray(myArray);
double[] massiv = res(myArray);
Console.WriteLine();
WriteArray(massiv);
*/
