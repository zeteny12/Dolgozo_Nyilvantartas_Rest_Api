using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Cache;
using Newtonsoft.Json;

namespace Dolgozo_Nyilvantartas_Rest_Api
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await DolgozokNyilvantartasa();

            Console.ReadKey();
        }

        //Api-ra csatlakozás
        private static async Task DolgozokNyilvantartasa()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://retoolapi.dev/Kc6xuH/data");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        DolgozokNyilvantartasaLekerdezes(jsonString);
                    }
                    else
                    {
                        Console.WriteLine("Hiba történt a csatlakozás során");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Lekérdezés
        private static void DolgozokNyilvantartasaLekerdezes(string jsonString)
        {
            Dolgozok[] dolgozok = JsonConvert.DeserializeObject<Dolgozok[]>(jsonString);

            Console.WriteLine($"Elemek száma: {dolgozok.Length}");
            Console.WriteLine($"Legmagasabb fizetéssel rendelkező dolgozó: {dolgozok.OrderByDescending(d => d.Salary).First().Name}");
            Console.WriteLine($"Fizetése: {dolgozok.OrderByDescending(d => d.Salary).First().Salary}$");
            Console.WriteLine($"\nMunkakörök: ");

            var munkakorok = dolgozok.GroupBy(d => d.Position).Select(g => new { Position = g.Key, Count = g.Count() });
            foreach (var munkakor in munkakorok)
            {
                Console.WriteLine($"\t{munkakor.Position} - {munkakor.Count}");
            }
        }
    }
}
