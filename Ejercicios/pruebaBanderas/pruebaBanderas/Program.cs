using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Threading.Tasks;
namespace pruebaBanderas
{
    internal class Program
    {

            static async Task Main(string[] args)
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://restcountries.com/v3.1/all";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        JArray countriesData = JArray.Parse(responseContent);

                        foreach (JToken countryData in countriesData)
                        {
                            string countryName = countryData["name"]["common"].ToString();
                            string countryAlpha3 = countryData["cca3"].ToString();
                            string countryFlag = countryData["flags"]["png"].ToString();

                            Console.WriteLine($"Country: {countryName}");
                            Console.WriteLine($"Alpha-3 Code: {countryAlpha3}");
                            Console.WriteLine($"Flag URL: {countryFlag}");
                            Console.WriteLine(new string('-', 30));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error fetching data");
                    }
                }
            }
        //static async Task Main(string[] args)
        //{
        //    string url = "http://country.io/names.json";

        //    // Descargar el JSON desde la URL
        //    using (HttpClient client = new HttpClient())
        //    {
        //        string json = await client.GetStringAsync(url);

        //        // Deserializar el JSON en un diccionario de siglas y nombres
        //        var paisDiccionario = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        //        // Crear una lista de objetos Pais
        //        List<Paises> paises = new List<Paises>();

        //        foreach (var kvp in paisDiccionario)
        //        {
        //            paises.Add(new Paises { Bandera = kvp.Key, Nombre = kvp.Value });
        //        }

        //        // Ahora tienes una lista de objetos Pais con las siglas y nombres correspondientes
        //        foreach (var pais in paises)
        //        {
        //            Console.WriteLine($"Bandera: {pais.Bandera}, Nombre: {pais.Nombre}");
        //        }
        //    }
        //}
    }
    public class Paises
    {
        public string Bandera { get; set; }
        public string? Siglas { get; set; }
        public string Nombre { get; set; }
    }
}
/*
 * using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "https://restcountries.com/v3.1/all";
            
            HttpResponseMessage response = await client.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                JArray countriesData = JArray.Parse(responseContent);
                
                foreach (JToken countryData in countriesData)
                {
                    string countryName = countryData["name"]["common"].ToString();
                    string countryAlpha3 = countryData["cca3"].ToString();
                    string countryFlag = countryData["flags"]["png"].ToString();
                    
                    Console.WriteLine($"Country: {countryName}");
                    Console.WriteLine($"Alpha-3 Code: {countryAlpha3}");
                    Console.WriteLine($"Flag URL: {countryFlag}");
                    Console.WriteLine(new string('-', 30));
                }
            }
            else
            {
                Console.WriteLine("Error fetching data");
            }
        }
    }
}

 */