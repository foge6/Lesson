// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
//  }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Change (int[,] array){
//     if (array.GetLength(0) == array.GetLength (1))
//     {
//         for (int j = 0; j< array.GetLength(1); j++)
//         {
//             for (int i = j+1; i < array.GetLength(0); i++)
//             {
//                 int temp = array [j,i];
//                 array[j,i]= array[i,j];
//                 array[i,j] = temp;
//             }
//         }
//         return array;
//     }
//     else
//     {
//     System.Console.WriteLine("Incorrect input");
//     return array;
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// System.Console.WriteLine();
// int[,] change = Change(array);
// Show2dArray(change);


// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая заменит сначения строк и 
// стобцов на нули на пересечении которых расположен наименьший элемент массива.


int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
 }
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Change (int[,] array){
int min = array[0,0];
int mini = 0;
int minj = 0;

    for (int j= 0; j < array.GetLength (1); j++)
    {
        for (int i = 0; i <array.GetLength (0); i++)
        {
            if ( array[j,i] < min)
            {
            min= array[j,i];
            mini=i;
            minj=j;
            }
        }
    }
    for (int j = 0; j < array.GetLength (1); j++)
    {
        for (int i = 0; i < array.GetLength (1); i++)
        {
            if (i == mini || j== minj)
            {
                array[j,i]=0;
            }
        }
    }
    return array;
}

Console.Write("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(m, n, min, max);
Show2dArray(array);
System.Console.WriteLine();
int[,] change = Change(array);
Show2dArray(change);