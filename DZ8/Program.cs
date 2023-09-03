/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRanddom(int m, int n)
{
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

void sort(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {    
                if (array[i, j] < array[i, k]) 
                {
                    int max = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = max;
                }
            }         
            
        }    
    }
}
 Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRanddom(m, n);
Show2dArray(myArray);
sort(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            
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

int minSum (int[,] array)
{
   
  
    int[] mas = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        mas[i] = sum;
    }
    int g = 1;
    int min = 0;
    for (int k = 0; g < array.GetLength(1); g++)
    {

        if (mas[k] >= mas[g])
        {
            min = g+1;
            k = g;
        }
        
    }
    return min;
}

int[,] myArray = CreateRanddom();
Show2dArray(myArray);
Console.WriteLine();
Console.WriteLine("The line with the minimum amount: " + minSum(myArray));
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] ymn(int[,] array, int[,] mas)
{
    int[,] res = new int[array.GetLength(0),mas.GetLength(1)];
    if (array.GetLength(1) == mas.GetLength(0))
     {
        for (int y = 0; y < array.GetLength(0); y++)
        {
            for(int x = 0; x < mas.GetLength(1); x++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    
                        res[y,x] += array[y,i] * mas[i,x];
                }
            }
        }   
        }  
        return res;
}


int[,] ferstArray = CreateRanddom();
int[,] secondArray = CreateRanddom();
Show2dArray(ferstArray);
Console.WriteLine();
Show2dArray(secondArray);
Console.WriteLine();
int[,] res = ymn(ferstArray, secondArray);
Show2dArray(ferstArray);
*/

/*Задача 60..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRanddom()
{
    
    Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of layer: ");
    int k = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[m,n,k];

    for(int x = 0; x < k; x++)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
                {
                    array[i, j, x] = new Random().Next(10, 100);
                }
        }
    }
    return array; 
}

void Show2dArray(int[,,] array)
{
    for(int x = 0; x < array.GetLength(2); x++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {   
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, x]} ({i},{j},{x})\t ");
            
            Console.WriteLine();
        }
    }
}




int[,,] ferstArray = CreateRanddom();
Show2dArray(ferstArray);

*/

/*Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRanddom()
{
    
    Console.WriteLine("Input a quantity of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a quantity of columbs: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[m,n];

    for( int x = 1, i = 0,j = 0;x <= m*n;x++ )
    {
        
        array[i,j] = x;
        if (i <= j + 1 && i+j < n-1 ) {j++; }
        else if (i < j && i + j >= m-1) {i++; }
        else if (i >= j && i + j > n-1) {j--; }
        else {i--; }
    }
    return array; 
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] < 10)
                Console.Write("0" + array[i, j] + " ");
            else
                Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}


int[,] ferstArray = CreateRanddom();
Show2dArray(ferstArray);
*/