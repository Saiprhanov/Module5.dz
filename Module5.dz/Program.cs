using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Module5.dz
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://store.steampowered.com"; // если указать (https://m.vk.com) будет так же как и со стимом
                                                                   //например если вбить (https://www.bmw-kz.com), то оно
                                                                   //будет долго грузить и через 10 секунд таймаут сработает
                                                                   // Установим таймаут на 10 секунд для запроса
                    client.Timeout = TimeSpan.FromSeconds(10);

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Запрос выполнен успешно.");
                    }
                    else
                    {
                        throw new System.Net.WebException("Ошибка при запросе к веб-ресурсу. Статус код: " + response.StatusCode);
                    }
                }
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine("Произошла ошибка при запросе к веб-ресурсу: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла неожиданная ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }
        }
    }
}
