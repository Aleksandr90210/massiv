using System;
public class MainClass
{
    public static void Main()
    {
        int[,] array1 = new int[12, 28];
        int[,] array2 = new int[12, 28];
        int[,] result = new int[12, 28];

        Random random = new Random();
        Console.WriteLine("Первый массив :");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                array1[i, j] = random.Next(100);
                Console.Write("{0,4}", array1[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Второй массив :");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                array2[i, j] = random.Next(100);
                Console.Write("{0,4}", array2[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Результат: ");
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                result[i, j] = array1[i, j] - array2[i, j];
                Console.Write("{0,4}", result[i, j]);
            }
            Console.WriteLine();
        }
    }
}


