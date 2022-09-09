using System.Text.Json.Serialization;

namespace Demo.App.Models.WeatherApi
{
  public class Current
    {
        [JsonPropertyName("observation_time")]
        public string ObservationTime { get; set; } = string.Empty;

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }

        [JsonPropertyName("weather_icons")]
        public List<string> WeatherIcons { get; set; } = new();

        [JsonPropertyName("weather_descriptions")]
        public List<string> WeatherDescriptions { get; set; } = new();

        [JsonPropertyName("wind_speed")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; } = string.Empty;

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("precip")]
        public double Precip { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloudcover")]
        public int CloudCover { get; set; }

        [JsonPropertyName("feelslike")]
        public int FeelsLike { get; set; }

        [JsonPropertyName("uv_index")]
        public int UvIndex { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonPropertyName("is_day")]
        public string IsDay { get; set; } = string.Empty;
    }    
}