using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5._3.dz
{
    class Exception1337 : Exception
    {
        public Exception1337(string message) : base(message)
        {
        }
    }

    class Exception228
    {
        static void Main()
        {
            try
            {
                CallMetod();
            }
            catch (Exception1337 ex)
            {
                Console.WriteLine("Исключение перехвачено в вызывающем методе: " + ex.Message);
            }
        }

        static void CallMetod()
        {
            try
            {
                Generalisimus();
            }
            catch (Exception1337 ex)
            {
                Console.WriteLine("Исключение перехвачено в вызываемом методе: " + ex.Message);
                throw; // Поднимаем исключение в вызывающий метод
            }
        }

        static void Generalisimus()
        {
            // Генерируем пользовательское исключение и передаем ему сообщение
            throw new Exception1337("!Произошла ошибка в вызываемом методе.");
        }
    }
}
