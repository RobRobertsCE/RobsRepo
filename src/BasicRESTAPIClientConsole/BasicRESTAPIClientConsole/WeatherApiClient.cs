using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Json;
using System.IO;


namespace BasicRESTAPIClientConsole
{
    public static class WeatherApiClient
    {
        public static void GetWeatherForecast()
        {
            // http://api.openweathermap.org/data/2.5/weather?q=efland,nc            
            var url = @"http://api.openweathermap.org/data/2.5/weather?q=efland,nc";

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            Console.WriteLine(content);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(WeatherData));

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (WeatherData)serializer.ReadObject(ms);
            }

        }
    }
}
