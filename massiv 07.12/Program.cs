using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Задаем размеры массива
        Console.Write("Введите n: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите m: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Полученная матрица: ");

        // Создаем двумерный массив заданного размера
        int[,] array = new int[rows, columns];

        // Заполняем массив случайными числами и выводим на экран
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 101); // случайные числа от 1 до 100
                Console.Write(array[i, j] + "\t"); // вывод элемента массива с табуляцией
            }
            Console.WriteLine(); // переход на новую строку для новой строки массива
        }
    }
}
