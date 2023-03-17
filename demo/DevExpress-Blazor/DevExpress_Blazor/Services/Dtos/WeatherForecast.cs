namespace DevExpress_Blazor.Services.Dtos
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);
        public string Forecast { get; set; }
        public string CloudCover { get; set; }
        public bool Precipitation { get; set; }
    }
}
