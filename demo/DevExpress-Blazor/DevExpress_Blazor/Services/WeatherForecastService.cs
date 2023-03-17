using DevExpress_Blazor.Services.Dtos;

namespace DevExpress_Blazor.Services
{
    public class WeatherForecastService
    {
        private List<WeatherForecast> Forecast { get; set; }

        private static string[] CloudCover = new[] {
            "Sunny", "Partly cloudy", "Cloudy", "Storm"
        };

        Tuple<int, string>[] ConditionsForForecast = new Tuple<int, string>[] {
            Tuple.Create( 22 , "Hot"),
            Tuple.Create( 13 , "Warm"),
            Tuple.Create( 0 , "Cold"),
            Tuple.Create( -10 , "Freezing")
        };

        public WeatherForecastService()
        {
            Forecast = CreateForecast();
        }

        private List<WeatherForecast> CreateForecast()
        {
            var rng = new Random();
            DateTime startDate = DateTime.Now;
            return Enumerable.Range(1, 15).Select(index => {
                var temperatureC = rng.Next(-10, 30);
                return new WeatherForecast
                {
                    Date = startDate.AddDays(index),
                    TemperatureC = temperatureC,
                    CloudCover = CloudCover[rng.Next(0, 4)],
                    Precipitation = Convert.ToBoolean(rng.Next(0, 2)),
                    Forecast = ConditionsForForecast.First(c => c.Item1 <= temperatureC).Item2
                };
            }).ToList();
        }

        public IEnumerable<WeatherForecast> GetForecast()
        {
            return Forecast.ToArray();
        }
        // ...
    }
}
