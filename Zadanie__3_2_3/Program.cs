using System;
/*Найти количество элементов массива, встречающихся в нем
один раз.*/


class Zadanie_3_2_3
{
    static void Main(string[] args)
    {

        int[] mas = new int[12] { 1, 1, 1, 4, 5, 6, 7, 8, 9, 10, 11, 1 };
        int count = 0;

        for (int k = 0; k < mas.Length; k++)
        {
            for (int i = 0; i < mas.Length; i++)

                if (mas[k] == mas[i] && k != i)
                {
                    count++;
                    break;
                }
        }

        if (count != 0)
            Console.WriteLine("Количество элементов массива, встречающихся в нем один раз - " + (mas.Length - count));
        else if (count == 0)
            Console.WriteLine("Количество элементов массива, встречающихся в нем один раз - " + (mas.Length));
    }
}
