using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5.dz
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                // Попытка обратиться к элементам массива вне его допустимого диапазона
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                // Обработка исключения, когда индекс находится вне пределов массива
                Console.WriteLine("Произошла ошибка индекса: " + ex.Message);
            }
            finally
            {
                // Этот блок будет выполнен всегда, даже после перехвата исключения
                Console.WriteLine("!Завершение обработки массива.");
            }
        }
    }
}