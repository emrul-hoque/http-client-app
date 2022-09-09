using System.Text.Json.Serialization;

namespace Demo.App.Models.WeatherApi
{
    public class WeatherRoot
    {
        [JsonPropertyName("request")]
        public Request? Request { get; set; }

        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("current")]
        public Current? Current { get; set; }
    }
}