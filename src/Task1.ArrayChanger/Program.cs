using System;
class Program
{
    static void Main()
    {
        /// <summary>
        /// Создание 2D массива (4*5)
        /// </summary>
        int[,] array = new int[4, 5]{
          {1, 2, 3, 4, 5},
          {6, 7, 8, 9, 10},
          {11, 12, 13, 14, 15},
          {16, 17, 18, 19, 20}
          };
        //Выводим оригинальный массив 
        Console.WriteLine("Оригинальный массив");
        PrintArray(array);
        //меняем места, симметричные относительно середины масива
        int numRows = array.GetLength(0);
        int middleRow = numRows / 2;
        for (int i = 0; i < middleRow; i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[numRows - 1 - i, j];
                array[numRows - 1 - i, j] = temp;
            }
        }
        //Выводим массив после изменения
        Console.WriteLine("Массив после изменения");
        PrintArray(array);
    }

    /// <summary>
    /// выводит массив в консоль 
    /// </summary>
    /// <param name="array">2D массив</param>
    static void PrintArray(int[,] array)
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
}
